using Essensoft.AspNetCore.Security;
using Essensoft.AspNetCore.WeChatPay.Parser;
using Essensoft.AspNetCore.WeChatPay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;
using Essensoft.AspNetCore.WeChatPay.Request;

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

        protected internal HttpClientHandler ClientHandler { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public WeChatPayCertificateClient(IOptions<WeChatPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new WeChatPayOptions();
            ClientHandler = new HttpClientHandler();

            if (File.Exists(Options.Certificate)) // 是文件则以文件名的形式创建，否则以Base64String方式
                ClientHandler.ClientCertificates.Add(new X509Certificate2(Options.Certificate, Options.MchId));
            else
                ClientHandler.ClientCertificates.Add(new X509Certificate2(Convert.FromBase64String(Options.Certificate), Options.MchId));

            Client = new HttpClientEx(ClientHandler);
        }

        public WeChatPayCertificateClient(string appId, string appSecret, string mchId, string key, string certificate)
            : this(null)
        {
            Options.Certificate = certificate;
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request) where T : WeChatPayResponse
        {
            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            if (request is WeChatPayTransfersRequest) // 企业付款到零钱
            {
                sortedTxtParams.Add(MCHAPPID, Options.AppId);
                sortedTxtParams.Add(MCHID, Options.MchId);
            }
            else if (request is WeChatPayGetPublicKeyRequest)
            {
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
            }
            else if (request is WeChatPayPayBankRequest || request is WeChatPayQueryBankRequest)
            {
                sortedTxtParams.Add(MCH_ID, Options.MchId);
            }
            else if (request is WeChatPayGetTransferInfoRequest)
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
                sortedTxtParams.Add(SIGN_TYPE, "MD5");
            }
            else // 其他接口
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
            }

            if (request is WeChatPayPayBankRequest) // 企业付款到银行卡接口
            {
                var no = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_BANK_NO), Options.RsaPublicKey);
                sortedTxtParams.SetValue(ENC_BANK_NO, no);

                var name = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_TRUE_NAME), Options.RsaPublicKey);
                sortedTxtParams.SetValue(ENC_TRUE_NAME, name);
            }

            sortedTxtParams.Add(NONCE_STR, Guid.NewGuid().ToString("N"));
            sortedTxtParams.Add(SIGN, Md5.GetMD5WithKey(sortedTxtParams, Options.Key, !(request is WeChatPayGetPublicKeyRequest))); // 获取公钥 不排除sign_type

            var body = await Client.DoPostAsync(request.GetRequestUrl(), sortedTxtParams);
            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckResponseSign(rsp);
            return rsp;
        }

        private void CheckResponseSign(WeChatPayResponse response)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = response.Sign;
            if (!response.IsError && !string.IsNullOrEmpty(sign))
            {
                var cal_sign = Md5.GetMD5WithKey(response.Parameters, Options.Key);
                if (cal_sign != sign)
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }
            }
        }
    }
}
