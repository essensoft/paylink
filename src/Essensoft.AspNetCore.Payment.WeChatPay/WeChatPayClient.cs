using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayClient : IWeChatPayClient
    {
        private const string appid = "appid";
        private const string mch_id = "mch_id";
        private const string mch_appid = "mch_appid";
        private const string mchid = "mchid";
        private const string wxappid = "wxappid";
        private const string sign_type = "sign_type";
        private const string nonce_str = "nonce_str";
        private const string sign = "sign";
        private const string enc_bank_no = "enc_bank_no";
        private const string enc_true_name = "enc_true_name";
        private const string partnerid = "partnerid";
        private const string noncestr = "noncestr";
        private const string timestamp = "timestamp";
        private const string appId = "appId";
        private const string timeStamp = "timeStamp";
        private const string nonceStr = "nonceStr";
        private const string signType = "signType";
        private const string paySign = "paySign";

        private readonly AsymmetricKeyParameter PublicKey;

        public virtual ILogger Logger { get; set; }

        public virtual IHttpClientFactory ClientFactory { get; set; }

        public WeChatPayOptions Options { get; }

        #region WeChatPayClient Constructors

        public WeChatPayClient(
            ILogger<WeChatPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptions<WeChatPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            Options = optionsAccessor.Value;

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

            if (!string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                PublicKey = RSAUtilities.GetPublicKeyParameterFormAsn1PublicKey(Options.RsaPublicKey);
            }
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request) where T : WeChatPayResponse
        {
            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters())
            {
                { mch_id, Options.MchId },
                { nonce_str, Guid.NewGuid().ToString("N") }
            };

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
            {
                sortedTxtParams.Add(appid, Options.AppId);
            }

            sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient())
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);
                Logger?.LogTrace(1, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var rsp = parser.Parse(body);
                CheckResponseSign(rsp);
                return rsp;
            }
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request) where T : WeChatPayResponse
        {
            var signType = true; // ture:MD5，false:HMAC-SHA256
            var excludeSignType = true;

            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            if (request is WeChatPayTransfersRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(mch_appid)))
                {
                    sortedTxtParams.Add(mch_appid, Options.AppId);
                }

                sortedTxtParams.Add(mchid, Options.MchId);
            }
            else if (request is WeChatPayGetPublicKeyRequest)
            {
                sortedTxtParams.Add(mch_id, Options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
                excludeSignType = false;
            }
            else if (request is WeChatPayPayBankRequest)
            {
                if (PublicKey == null)
                {
                    throw new ArgumentNullException(nameof(Options.RsaPublicKey));
                }

                var no = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(enc_bank_no), PublicKey);
                sortedTxtParams.SetValue(enc_bank_no, no);

                var name = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(enc_true_name), PublicKey);
                sortedTxtParams.SetValue(enc_true_name, name);

                sortedTxtParams.Add(mch_id, Options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayQueryBankRequest)
            {
                sortedTxtParams.Add(mch_id, Options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayGetTransferInfoRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, Options.AppId);
                }

                sortedTxtParams.Add(mch_id, Options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayDownloadFundFlowRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, Options.AppId);
                }

                sortedTxtParams.Add(mch_id, Options.MchId);
                signType = false; // HMAC-SHA256
            }
            else if (request is WeChatPayRefundRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, Options.AppId);
                }

                sortedTxtParams.Add(mch_id, Options.MchId);
            }
            else if (request is WeChatPaySendRedPackRequest || request is WeChatPaySendGroupRedPackRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(wxappid)))
                {
                    sortedTxtParams.Add(wxappid, Options.AppId);
                }

                sortedTxtParams.Add(mch_id, Options.MchId);
            }
            else // 其他接口
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, Options.AppId);
                }

                sortedTxtParams.Add(mch_id, Options.MchId);
            }

            sortedTxtParams.Add(nonce_str, Guid.NewGuid().ToString("N"));
            sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key, signType, excludeSignType));

            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient(WeChatPayOptions.CertificateClientName))
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);

                Logger?.LogTrace(1, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var rsp = parser.Parse(body);
                CheckResponseSign(rsp, signType, excludeSignType);
                return rsp;
            }
        }

        #endregion

        #region IWeChatPayClient Members

        public Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayCalcRequest request)
        {
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            if (request is WeChatPayAppCallPaymentRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, Options.AppId);
                }

                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(partnerid)))
                {
                    sortedTxtParams.Add(partnerid, Options.MchId);
                }
                sortedTxtParams.Add(noncestr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(timestamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            }
            else if (request is WeChatPayLiteAppCallPaymentRequest || request is WeChatPayH5CallPaymentRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appId)))
                {
                    sortedTxtParams.Add(appId, Options.AppId);
                }

                sortedTxtParams.Add(timeStamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(nonceStr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(signType, "MD5");
                sortedTxtParams.Add(paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            }
            return Task.FromResult(sortedTxtParams);
        }

        #endregion

        #region Common Method

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

        #endregion
    }
}
