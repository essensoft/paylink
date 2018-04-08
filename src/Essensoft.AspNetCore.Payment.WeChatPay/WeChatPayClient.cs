using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayClient : IWeChatPayClient
    {
        private const string APPID = "appid";
        private const string MCH_ID = "mch_id";
        private const string MCH_APPID = "mch_appid";
        private const string MCHID = "mchid";
        private const string SIGN_TYPE = "sign_type";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        private const string ENC_BANK_NO = "enc_bank_no";
        private const string ENC_TRUE_NAME = "enc_true_name";

        private ICipherParameters RsaPublicParameters;

        public WeChatPayOptions Options { get; set; }

        public virtual ILogger<WeChatPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        protected internal HttpClientEx CertificateClient { get; set; }

        public WeChatPayClient(
            IOptions<WeChatPayOptions> optionsAccessor,
            ILogger<WeChatPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new WeChatPayOptions();
            Logger = logger;
            Client = new HttpClientEx();

            if (string.IsNullOrEmpty(Options.AppId))
            {
                throw new ArgumentNullException(nameof(Options.AppId));
            }

            if (string.IsNullOrEmpty(Options.MchId))
            {
                throw new ArgumentNullException(nameof(Options.MchId));
            }

            if (string.IsNullOrEmpty(Options.Key))
            {
                throw new ArgumentNullException(nameof(Options.Key));
            }

            if (!string.IsNullOrEmpty(Options.Certificate))
            {
                var clientHandler = new HttpClientHandler();
                var certificate = Convert.FromBase64String(Options.Certificate);
                clientHandler.ClientCertificates.Add(new X509Certificate2(certificate, Options.MchId, X509KeyStorageFlags.MachineKeySet));
                CertificateClient = new HttpClientEx(clientHandler);
            }

            if (!string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                RsaPublicParameters = WeChatPaySignature.GetPublicKeyParameters(Options.RsaPublicKey);
            }
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);

            if (CertificateClient != null)
            {
                CertificateClient.Timeout = new TimeSpan(0, 0, 0, timeout);
            }
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request) where T : WeChatPayResponse
        {
            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters())
            {
                { APPID, Options.AppId },
                { MCH_ID, Options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            sortedTxtParams.Add(SIGN, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger.LogInformation(0, "Request:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response:{content}", rspContent);


            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(rspContent);
            CheckResponseSign(rsp);
            return rsp;
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request) where T : WeChatPayResponse
        {
            var useMD5 = true;
            var excludeSignType = true;

            if (CertificateClient == null)
            {
                throw new ArgumentNullException(nameof(Options.Certificate));
            }

            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            if (request is WeChatPayTransfersRequest)
            {
                sortedTxtParams.Add(MCH_APPID, Options.AppId);
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
                if (RsaPublicParameters == null)
                {
                    throw new ArgumentNullException(nameof(Options.RsaPublicKey));
                }

                var no = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_BANK_NO), RsaPublicParameters);
                sortedTxtParams.SetValue(ENC_BANK_NO, no);

                var name = WeChatPaySignature.Encrypt(sortedTxtParams.GetValue(ENC_TRUE_NAME), RsaPublicParameters);
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
            else if (request is WeChatPayRefundRequest)
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
            }
            else // 其他接口
            {
                sortedTxtParams.Add(APPID, Options.AppId);
                sortedTxtParams.Add(MCH_ID, Options.MchId);
            }

            sortedTxtParams.Add(NONCE_STR, Guid.NewGuid().ToString("N"));
            sortedTxtParams.Add(SIGN, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key, useMD5, excludeSignType));

            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger.LogInformation(0, "Request:{content}", content);

            var rspContent = await CertificateClient.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response:{content}", rspContent);

            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(rspContent);
            CheckResponseSign(rsp, useMD5, excludeSignType);
            return rsp;
        }

        private void CheckResponseSign(WeChatPayResponse response, bool useMD5 = true, bool excludeSignType = true)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            if (response.Parameters.TryGetValue("sign", out var sign))
            {
                if (response.Parameters["return_code"] == "SUCCESS" && !string.IsNullOrEmpty(sign))
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
}
