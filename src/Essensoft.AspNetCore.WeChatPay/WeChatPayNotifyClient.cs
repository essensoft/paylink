using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Security;
using Essensoft.AspNetCore.WeChatPay.Notify;
using Essensoft.AspNetCore.WeChatPay.Parser;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.WeChatPay
{
    public class WeChatPayNotifyClient
    {
        public WeChatPayOptions Options { get; set; }

        public WeChatPayNotifyClient(IOptions<WeChatPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new WeChatPayOptions();
        }

        public WeChatPayNotifyClient(string key)
            : this(optionsAccessor: null)
        {
            Options.Key = key;
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotifyResponse
        {
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(body);
            if (rsp is WeChatPayRefundNotifyResponse)
            {
                var key = Md5.GetMD5(Options.Key).ToLower();
                var data = Aes.AesDecrypt(rsp.ReqInfo, key); // AES-256-ECB
                rsp = parser.Parse(rsp, data);
            }
            else
            {
                CheckNotifySign(rsp);
            }
            return rsp;
        }

        private void CheckNotifySign(WeChatPayNotifyResponse response)
        {
            if (response?.Parameters?.Count == 0)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = response?.Sign;
            if (string.IsNullOrEmpty(sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var cal_sign = Md5.GetMD5WithKey(response.Parameters, Options.Key);
            if (cal_sign != sign)
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }
    }
}