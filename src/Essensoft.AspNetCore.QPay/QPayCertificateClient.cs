using Essensoft.AspNetCore.QPay.Parser;
using Essensoft.AspNetCore.QPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;

namespace Essensoft.AspNetCore.QPay
{
    public class QPayCertificateClient : IQPayCertificateClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; set; }

        protected internal HttpClientHandler ClientHandler { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public QPayCertificateClient(IOptions<QPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new QPayOptions();
            ClientHandler = new HttpClientHandler();

            if (File.Exists(Options.Certificate)) // 是文件则以文件名的形式创建，否则以Base64String方式
                ClientHandler.ClientCertificates.Add(new X509Certificate2(Options.Certificate, Options.MchId));
            else
                ClientHandler.ClientCertificates.Add(new X509Certificate2(Convert.FromBase64String(Options.Certificate), Options.MchId));

            Client = new HttpClientEx(ClientHandler);
        }

        public QPayCertificateClient(string appId, string appSecret, string mchId, string key, string certificate)
            : this(null)
        {
            Options.AppId = appId;
            Options.AppSecret = appSecret;
            Options.MchId = mchId;
            Options.Key = key;
            Options.Certificate = certificate;
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

            sortedTxtParams.Add(SIGN, Md5.GetMD5WithKey(sortedTxtParams, Options.Key));

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

            var sign = response.Sign;
            if (!response.IsError && !string.IsNullOrEmpty(sign))
            {
                var cal_sign = Md5.GetMD5WithKey(response.Parameters, Options.Key);
                if (cal_sign != sign)
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }
            }
        }

    }
}
