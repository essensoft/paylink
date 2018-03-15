using Essensoft.AspNetCore.QPay.Parser;
using Essensoft.AspNetCore.QPay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.QPay
{
    public class QPayCertificateClient : IQPayCertificateClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public QPayCertificateClient(QPayOptions options)
        {
            Options = options;

            if (string.IsNullOrEmpty(Options.Certificate) || string.IsNullOrEmpty(Options.MchId))
            {
                throw new Exception("Error Certificate or MchId is Empty!");
            }
           var clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificates.Add(new X509Certificate2(Convert.FromBase64String(Options.Certificate), Options.MchId, X509KeyStorageFlags.MachineKeySet));
            Client = new HttpClientEx(clientHandler);
        }

        public QPayCertificateClient(IOptions<QPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new QPayOptions())
        {
        }

        public QPayCertificateClient(string appId, string appSecret, string mchId, string key, string certificate)
            : this(new QPayOptions { AppId = appId, AppSecret = appSecret, MchId = mchId, Key = key, Certificate = certificate })
        {
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

            var body = await Client.DoPostAsync(request.GetRequestUrl(), sortedTxtParams);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
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
