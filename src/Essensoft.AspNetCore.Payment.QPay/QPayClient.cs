using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayClient : IQPayClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; set; }

        public virtual ILogger<QPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public QPayClient(
            IOptions<QPayOptions> optionsAccessor,
            ILogger<QPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new QPayOptions();
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
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        public async Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse
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
