using System;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Request;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.QPay
{
    /// <summary>
    /// QPay 客户端。
    /// </summary>
    public class QPayClient : IQPayClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";
        private const string UIN = "uin";
        private const string OPENID = "openid";
        
        private readonly ILogger _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOptionsSnapshot<QPayOptions> _optionsSnapshotAccessor;

        #region QPayClient Constructors

        public QPayClient(
            ILogger<QPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<QPayOptions> optionsAccessor)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IQPayRequest<T> request, string optionsName) where T : QPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = new QPayDictionary(request.GetParameters())
            {
                { MCHID, options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            if (request is QPayEPayQueryRequest)
            {
            }
            else if (request is QPayEPayStatementDownRequest)
            {
            }
            else
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(APPID)))
                {
                    sortedTxtParams.Add(APPID, options.AppId);
                }
            }

            sortedTxtParams.Add(SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));

            var content = QPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = _clientFactory.CreateClient())
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new QPayXmlParser<T>();
                var rsp = parser.Parse(body);

                if (request.IsCheckResponseSign())
                {
                    CheckResponseSign(rsp, options);
                }

                return rsp;
            }
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string certificateName) where T : QPayResponse
        {
            return await ExecuteAsync(request, null, certificateName);
        }

        public async Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string optionsName, string certificateName) where T : QPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = new QPayDictionary(request.GetParameters())
            {
                { MCHID, options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            if (request is QPayEPayB2CRequest)
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(OPENID)) && string.IsNullOrEmpty(sortedTxtParams.GetValue(UIN)) && string.IsNullOrEmpty(sortedTxtParams.GetValue(APPID)))
                {
                    sortedTxtParams.Add(APPID, options.AppId);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(sortedTxtParams.GetValue(APPID)))
                {
                    sortedTxtParams.Add(APPID, options.AppId);
                }
            }

            sortedTxtParams.Add(SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
            var content = QPayUtility.BuildContent(sortedTxtParams);
            _logger.Log(options.LogLevel, "Request:{content}", content);
            using (var client = string.IsNullOrEmpty(certificateName) ? _clientFactory.CreateClient() : _clientFactory.CreateClient(certificateName))
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                _logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new QPayXmlParser<T>();
                var rsp = parser.Parse(body);

                if (request.IsCheckResponseSign())
                {
                    CheckResponseSign(rsp, options);
                }

                return rsp;
            }
        }

        #endregion

        #region Common Method

        private void CheckResponseSign(QPayResponse response, QPayOptions options)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new QPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new QPayException("sign check fail: Parameters is Empty!");
            }

            if (response.Parameters["return_code"] == "SUCCESS")
            {
                if (!response.Parameters.TryGetValue("sign", out var sign))
                {
                    throw new QPayException("sign check fail: sign is Empty!");
                }

                var cal_sign = QPaySignature.SignWithKey(response.Parameters, options.Key);
                if (cal_sign != sign)
                {
                    throw new QPayException("sign check fail: check Sign and Data Fail!");
                }
            }
        }

        #endregion
    }
}
