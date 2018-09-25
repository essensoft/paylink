using System;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayClient : IQPayClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public virtual ILogger Logger { get; set; }

        public virtual IHttpClientFactory ClientFactory { get; set; }

        public QPayOptions Options { get; protected set; }

        #region QPayClient Constructors

        public QPayClient(
            ILogger<QPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptions<QPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            Options = optionsAccessor.Value;

            if (string.IsNullOrEmpty(Options.MchId))
            {
                throw new ArgumentNullException(nameof(Options.MchId));
            }

            if (string.IsNullOrEmpty(Options.Key))
            {
                throw new ArgumentNullException(nameof(Options.Key));
            }
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse
        {
            // 字典排序
            var sortedTxtParams = new QPayDictionary(request.GetParameters())
            {
                { MCHID, Options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(APPID)))
            {
                sortedTxtParams.Add(APPID, Options.AppId);
            }

            sortedTxtParams.Add(SIGN, QPaySignature.SignWithKey(sortedTxtParams, Options.Key));

            var content = QPayUtility.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient(QPayOptions.DefaultClientName))
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);
                Logger?.LogTrace(1, "Response:{body}", body);

                var parser = new QPayXmlParser<T>();
                var rsp = parser.Parse(body);
                CheckResponseSign(rsp);
                return rsp;
            }
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string certificateName = "Default") where T : QPayResponse
        {
            // 字典排序
            var sortedTxtParams = new QPayDictionary(request.GetParameters())
            {
                { MCHID, Options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(APPID)))
            {
                sortedTxtParams.Add(APPID, Options.AppId);
            }

            sortedTxtParams.Add(SIGN, QPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            var content = QPayUtility.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient(QPayOptions.CertificateClientName + "." + certificateName))
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);
                Logger?.LogTrace(1, "Response:{body}", body);

                var parser = new QPayXmlParser<T>();
                var rsp = parser.Parse(body);
                CheckResponseSign(rsp);
                return rsp;
            }
        }

        #endregion

        #region Common Method

        private void CheckResponseSign(QPayResponse response)
        {
            if (string.IsNullOrEmpty(response.Body) || response?.Parameters == null)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            if (response.Parameters.TryGetValue("sign", out var sign))
            {
                if (response.Parameters["return_code"] == "SUCCESS" && !string.IsNullOrEmpty(sign))
                {
                    var cal_sign = QPaySignature.SignWithKey(response.Parameters, Options.Key);
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
