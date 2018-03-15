using Essensoft.AspNetCore.WeChatPay.Parser;
using Essensoft.AspNetCore.WeChatPay.Request;
using Essensoft.AspNetCore.WeChatPay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.WeChatPay
{
    public class WeChatPayCertificateClient : IWeChatPayCertificateClient
    {
        private const string APPID = "appid";
        private const string MCH_ID = "mch_id";
        private const string MCHAPPID = "mch_appid";
        private const string MCHID = "mchid";
        private const string SIGN_TYPE = "sign_type";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";
        private const string ENC_BANK_NO = "enc_bank_no";
        private const string ENC_TRUE_NAME = "enc_true_name";

        public WeChatPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public WeChatPayCertificateClient(WeChatPayOptions options)
        {
            Options = options;

            if (string.IsNullOrEmpty(Options.Certificate) || string.IsNullOrEmpty(Options.MchId))
            {
                throw new Exception("Error Certificate or MchId is Empty!");
            }

            var clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificates.Add(new X509Certificate2(Convert.FromBase64String(Options.Certificate), Options.MchId, X509KeyStorageFlags.MachineKeySet));
            Client = new HttpClientEx(clientHandler);
        }

        public WeChatPayCertificateClient(IOptions<WeChatPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new WeChatPayOptions())
        {
        }

        public WeChatPayCertificateClient(string appId, string appSecret, string mchId, string key, string certificate)
            : this(new WeChatPayOptions { AppId = appId, AppSecret = appSecret, MchId = mchId, Key = key, Certificate = certificate })
        {
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request) where T : WeChatPayResponse
        {
            var useMD5 = true;
            var excludeSignType = true;

            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            if (request is WeChatPayTransfersRequest)
            {
                sortedTxtParams.Add(MCHAPPID, Options.AppId);
                sortedTxtParams.Add(MCHID, Options.MchId);
            }
            else if (request is WeChatPayGetPublicKeyRequest)
            {
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
                excludeSignType = false;
            }
            else if (request is WeChatPayPayBankRequest)
            {
                var no = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_BANK_NO), Options.RsaPublicParameters);
                sortedTxtParams.SetValue(ENC_BANK_NO, no);

                var name = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_TRUE_NAME), Options.RsaPublicParameters);
                sortedTxtParams.SetValue(ENC_TRUE_NAME, name);

                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
            }
            else if (request is WeChatPayQueryBankRequest)
            {
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
            }
            else if (request is WeChatPayGetTransferInfoRequest)
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
            }
            else if (request is WeChatPayDownloadFundFlowRequest)
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "HMAC-SHA256");
                useMD5 = false;
                excludeSignType = false;
            }
            else // 其他接口
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
            }

            sortedTxtParams.Add(NONCE_STR, Guid.NewGuid().ToString("N"));
            sortedTxtParams.Add(SIGN, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key, useMD5, excludeSignType));

            var body = await Client.DoPostAsync(request.GetRequestUrl(), sortedTxtParams);
            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckResponseSign(rsp, useMD5, excludeSignType);
            return rsp;
        }

        private void CheckResponseSign(WeChatPayResponse response, bool useMD5, bool excludeSignType)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = response?.Sign;
            if (!response.IsError && !string.IsNullOrEmpty(sign))
            {
                var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, Options.Key, useMD5, excludeSignType);
                if (cal_sign != sign)
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }
            }
        }
    }
}
