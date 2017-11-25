using Essensoft.AspNetCore.QPay.Parser;
using Essensoft.AspNetCore.QPay.Utility;
using Essensoft.AspNetCore.Security;
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

        public QPayClient(IOptions<QPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new QPayOptions();
            Client = new HttpClientEx();
        }

        public QPayClient(string mchId, string key)
            : this(null)
        {
            Options.MchId = mchId;
            Options.Key = key;
        }

        public QPayClient(string appId, string appSecret, string mchId, string key)
            : this(mchId, key)
        {
            Options.AppId = appId;
            Options.AppSecret = appSecret;
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

            var sign = response?.Sign;
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
