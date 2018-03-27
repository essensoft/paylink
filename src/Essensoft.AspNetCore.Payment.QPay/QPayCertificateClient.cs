using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayCertificateClient : IQPayCertificateClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; set; }

        public virtual ILogger<QPayCertificateClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public QPayCertificateClient(
            IOptions<QPayOptions> optionsAccessor,
            ILogger<QPayCertificateClient> logger)
        {
            Options = optionsAccessor?.Value ?? new QPayOptions();
            Logger = logger;

            if (string.IsNullOrEmpty(Options.MchId))
            {
                throw new ArgumentNullException(nameof(Options.MchId));
            }

            if (string.IsNullOrEmpty(Options.Key))
            {
                throw new ArgumentNullException(nameof(Options.Key));
            }

            if (string.IsNullOrEmpty(Options.Certificate))
            {
                throw new ArgumentNullException(nameof(Options.Certificate));
            }

            var clientHandler = new HttpClientHandler();
            var certificate = Convert.FromBase64String(Options.Certificate);
            clientHandler.ClientCertificates.Add(new X509Certificate2(certificate, Options.MchId, X509KeyStorageFlags.MachineKeySet));
            Client = new HttpClientEx(clientHandler);
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        public async Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request) where T : QPayResponse
        {
            // 字典排序
            var sortedTxtParams = new QPayDictionary(request.GetParameters())
            {
                { APPID, Options.AppId },
                { MCHID, Options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            sortedTxtParams.Add(SIGN, QPaySignature.SignWithKey(sortedTxtParams, Options.Key));
            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger.LogInformation(0, "Request Content:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response Content:{content}", rspContent);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(rspContent);
            CheckResponseSign(rsp);
            return rsp;
        }

        private void CheckResponseSign(QPayResponse response)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = response?.Sign;
            if (!response.IsError && !string.IsNullOrEmpty(sign))
            {
                var cal_sign = QPaySignature.SignWithKey(response.Parameters, Options.Key);
                if (cal_sign != sign)
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }
            }
        }

    }
}
