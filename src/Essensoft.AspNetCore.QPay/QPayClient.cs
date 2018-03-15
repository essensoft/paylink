using Essensoft.AspNetCore.QPay.Parser;
using Essensoft.AspNetCore.QPay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.QPay
{
    public class QPayClient : IQPayClient
    {
        private const string APPID = "appid";
        private const string MCHID = "mch_id";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public QPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public QPayClient(QPayOptions options)
        {
            Options = options;
            Client = new HttpClientEx();
        }

        public QPayClient(IOptions<QPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new QPayOptions())
        {
        }

        public QPayClient(string mchId, string key)
            : this(new QPayOptions { MchId = mchId, Key = key })
        {
        }

        public QPayClient(string appId, string appSecret, string mchId, string key)
            : this(new QPayOptions { AppId = appId, AppSecret = appSecret, MchId = mchId, Key = key })
        {
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

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), sortedTxtParams);
            if (string.IsNullOrEmpty(rspContent))
            {
                throw new Exception("rspContent is Empty!");
            }

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
