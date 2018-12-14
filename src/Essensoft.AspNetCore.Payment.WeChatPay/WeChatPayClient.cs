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

            var sortedTxtParams = request.HandleParametersAndSign(options);
            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = _clientFactory.CreateClient())
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var response = parser.Parse(body);

                request.CheckResponseSign(response, options);

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
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = request.HandleParametersAndSign(options);

            var content = WeChatPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = _clientFactory.CreateClient(certificateName))
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new WeChatPayXmlParser<T>();
                var response = parser.Parse(body);

                request.CheckResponseSign(response, options);

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
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
                {
                    sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
                }

                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_partnerid)))
                {
                    sortedTxtParams.Add(ConstKey.Key_partnerid, options.MchId);
                }
                sortedTxtParams.Add(ConstKey.Key_noncestr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(ConstKey.Key_timestamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(ConstKey.Key_sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key));
            } else if (request is WeChatPayLiteAppCallPaymentRequest || request is WeChatPayH5CallPaymentRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appId)))
                {
                    sortedTxtParams.Add(ConstKey.Key_appId, options.AppId);
                }

                sortedTxtParams.Add(ConstKey.Key_timeStamp, WeChatPayUtility.GetTimeStamp());
                sortedTxtParams.Add(ConstKey.Key_nonceStr, Guid.NewGuid().ToString("N"));
                sortedTxtParams.Add(ConstKey.Key_signType, "MD5");
                sortedTxtParams.Add(ConstKey.Key_paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key));
            }

            return Task.FromResult(sortedTxtParams);
        }

        #endregion

    }
}
