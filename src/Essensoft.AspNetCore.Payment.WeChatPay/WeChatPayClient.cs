using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayClient : IWeChatPayClient
    {
        private const string APPID = "appid";
        private const string MCH_ID = "mch_id";
        private const string MCH_APPID = "mch_appid";
        private const string MCHID = "mchid";
        private const string SIGN_TYPE = "sign_type";
        private const string NONCE_STR = "nonce_str";
        private const string SIGN = "sign";

        public WeChatPayOptions Options { get; set; }

        public virtual ILogger<WeChatPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public WeChatPayClient(
            IOptions<WeChatPayOptions> optionsAccessor,
            ILogger<WeChatPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new WeChatPayOptions();
            Logger = logger;
            Client = new HttpClientEx();

            if (string.IsNullOrEmpty(Options.AppId))
            {
                throw new ArgumentNullException(nameof(Options.AppId));
            }

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
            var content = HttpClientEx.BuildContent(sortedTxtParams);
            Logger.LogInformation(0, "Request Content:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response Content:{content}", rspContent);

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
