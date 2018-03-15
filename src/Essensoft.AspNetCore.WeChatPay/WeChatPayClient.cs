using Essensoft.AspNetCore.WeChatPay.Parser;
using Essensoft.AspNetCore.WeChatPay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.WeChatPay
{
    public class WeChatPayClient : IWeChatPayClient
    {
        private const string APPID = "appid";
        private const string MCH_ID = "mch_id";
        private const string MCHAPPID = "mch_appid";
        private const string MCHID = "mchid";
        private const string SIGN_TYPE = "sign_type";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public WeChatPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public WeChatPayClient(WeChatPayOptions options)
        {
            Options = options;
            Client = new HttpClientEx();
        }

        public WeChatPayClient(IOptions<WeChatPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new WeChatPayOptions())
        {
        }

        public WeChatPayClient(string appId, string appSecret, string mchId, string key)
            : this(new WeChatPayOptions { AppId = appId, AppSecret = appSecret, MchId = mchId, Key = key })
        {
        }

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request) where T : WeChatPayResponse
        {
            // 字典排序
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters())
            {
                { APPID, Options.AppId },
                { MCH_ID, Options.MchId },
                { NONCE_STR, Guid.NewGuid().ToString("N") }
            };

            sortedTxtParams.Add(SIGN, WeChatPaySignature.SignWithKey(sortedTxtParams, Options.Key));

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), sortedTxtParams);
            if (string.IsNullOrEmpty(rspContent))
            {
                throw new Exception("rspContent is Empty!");
            }

            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(rspContent);
            CheckResponseSign(rsp);
            return rsp;
        }

        private void CheckResponseSign(WeChatPayResponse response)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = response?.Sign;
            if (!response.IsError && !string.IsNullOrEmpty(sign))
            {
                var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, Options.Key);
                if (cal_sign != sign)
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }
            }
        }
    }
}
