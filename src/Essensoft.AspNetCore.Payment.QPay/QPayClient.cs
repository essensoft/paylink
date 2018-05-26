using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayClient : IQPayClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; }

        public virtual ILogger Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        protected internal HttpClientEx CertificateClient { get; set; }

        #region QPayClient Constructors

        public QPayClient(
            IOptions<QPayOptions> optionsAccessor,
            ILogger<QPayClient> logger)
        {
            Options = optionsAccessor.Value;
            Logger = logger;
            Client = new HttpClientEx();

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
                clientHandler.ClientCertificates.Add(File.Exists(Options.Certificate) ? new X509Certificate2(Options.Certificate, Options.MchId) :
                    new X509Certificate2(Convert.FromBase64String(Options.Certificate), Options.MchId, X509KeyStorageFlags.MachineKeySet));
                CertificateClient = new HttpClientEx(clientHandler);
            }
        }

        public QPayClient(IOptions<QPayOptions> optionsAccessor)
            : this(optionsAccessor, null)
        { }

        #endregion

        #region IQPayClient Members

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);

            if (CertificateClient != null)
            {
                CertificateClient.Timeout = new TimeSpan(0, 0, 0, timeout);
            }
        }

        #endregion IQPayClient Members

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

            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            var body = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger?.LogTrace(1, "Response:{body}", body);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckResponseSign(rsp);
            return rsp;
        }

        #endregion

        #region IQPayClient Members

        public async Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request) where T : QPayResponse
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
            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            var body = await CertificateClient.DoPostAsync(request.GetRequestUrl(), content);
            Logger?.LogTrace(1, "Response:{content}", body);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckResponseSign(rsp);
            return rsp;
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
