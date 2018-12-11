using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 客户端。
    /// </summary>
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
        private const string workwx_sign = "workwx_sign";

        private readonly ILogger _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptionsSnapshot<WeChatPayOptions> _optionsSnapshotAccessor;

        #region WeChatPayClient Constructors

        public WeChatPayClient(
            ILogger<WeChatPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<WeChatPayOptions> optionsAccessor)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request) where T : WeChatPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, string optionsName) where T : WeChatPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters())
            {
                { mch_id, options.MchId },
                { nonce_str, Guid.NewGuid().ToString("N") }
            };

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
            {
                sortedTxtParams.Add(appid, options.AppId);
            }

            sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key));
            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = _clientFactory.CreateClient())
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var response = parser.Parse(body);

                if (request.IsCheckResponseSign())
                {
                    CheckResponseSign(response, options);
                }

                return response;
            }
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request, string certificateName) where T : WeChatPayResponse
        {
            return await ExecuteAsync(request, null, certificateName);
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request, string optionsName, string certificateName) where T : WeChatPayResponse
        {
            var signType = true; // ture:MD5，false:HMAC-SHA256
            var excludeSignType = true;
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters())
            {
                { nonce_str, Guid.NewGuid().ToString("N") }
            };

            if (request is WeChatPayTransfersRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(mch_appid)))
                {
                    sortedTxtParams.Add(mch_appid, options.AppId);
                }

                sortedTxtParams.Add(mchid, options.MchId);
            }
            else if (request is WeChatPayGetPublicKeyRequest)
            {
                sortedTxtParams.Add(mch_id, options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
                excludeSignType = false;
            }
            else if (request is WeChatPayPayBankRequest)
            {
                if (options.PublicKey == null)
                {
                    throw new WeChatPayException("WeChatPayPayBankRequest: PublicKey is null!");
                }

                var no = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(enc_bank_no), options.PublicKey);
                sortedTxtParams.SetValue(enc_bank_no, no);

                var name = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(sortedTxtParams.GetValue(enc_true_name), options.PublicKey);
                sortedTxtParams.SetValue(enc_true_name, name);

                sortedTxtParams.Add(mch_id, options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayQueryBankRequest)
            {
                sortedTxtParams.Add(mch_id, options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayGetTransferInfoRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);
                sortedTxtParams.Add(sign_type, "MD5");
            }
            else if (request is WeChatPayDownloadFundFlowRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);
                signType = false; // HMAC-SHA256
            }
            else if (request is WeChatPayRefundRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);
            }
            else if (request is WeChatPaySendRedPackRequest || request is WeChatPaySendGroupRedPackRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(wxappid)))
                {
                    sortedTxtParams.Add(wxappid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);
            }
            else if (request is WeChatPaySendWorkWxRedPackRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(wxappid)))
                {
                    sortedTxtParams.Add(wxappid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);

                var sign_list = new List<string>
                {
                    "act_name",
                    "mch_billno",
                    "mch_id",
                    "nonce_str",
                    "re_openid",
                    "total_amount",
                    "wxappid",
                };

                sortedTxtParams.Add(workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.Secret, sign_list));
            }
            else if (request is WeChatPayPayWwSpTrans2PockeRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);

                var sign_list = new List<string>
                {
                    "amount",
                    "appid",
                    "desc",
                    "mch_id",
                    "nonce_str",
                    "openid",
                    "partner_trade_no",
                    "ww_msg_type",
                };

                sortedTxtParams.Add(workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.Secret, sign_list));
            }
            else // 其他接口
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                sortedTxtParams.Add(mch_id, options.MchId);
            }

            sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType, excludeSignType));

            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = _clientFactory.CreateClient(certificateName))
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var response = parser.Parse(body);

                if (request.IsCheckResponseSign())
                {
                    CheckResponseSign(response, options, signType, excludeSignType);
                }

                return response;
            }
        }

        #endregion

        #region IWeChatPayClient Members

        public Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayCallRequest request)
        {
            return ExecuteAsync(request, null);
        }

        public Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayCallRequest request, string optionsName)
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            if (request is WeChatPayAppCallPaymentRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appid)))
                {
                    sortedTxtParams.Add(appid, options.AppId);
                }

                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(partnerid)))
                {
                    sortedTxtParams.Add(partnerid, options.MchId);
                }

                sortedTxtParams.Add(noncestr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(timestamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key));
            }
            else if (request is WeChatPayLiteAppCallPaymentRequest || request is WeChatPayH5CallPaymentRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(appId)))
                {
                    sortedTxtParams.Add(appId, options.AppId);
                }

                sortedTxtParams.Add(timeStamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(nonceStr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(signType, "MD5");
                sortedTxtParams.Add(paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key));
            }

            return Task.FromResult(sortedTxtParams);
        }

        #endregion

        #region Common Method

        private void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options, bool useMD5 = true, bool excludeSignType = true)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (response.Parameters["return_code"] == "SUCCESS")
            {
                if (!response.Parameters.TryGetValue("sign", out var sign))
                {
                    throw new WeChatPayException("sign check fail: sign is Empty!");
                }

                var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, options.Key, useMD5, excludeSignType);
                if (cal_sign != sign)
                {
                    throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
                }
            }
        }

        #endregion
    }
}
