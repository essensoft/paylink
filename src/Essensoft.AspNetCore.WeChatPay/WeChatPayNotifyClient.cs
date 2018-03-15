using Essensoft.AspNetCore.Security;
using Essensoft.AspNetCore.WeChatPay.Notify;
using Essensoft.AspNetCore.WeChatPay.Parser;
using Essensoft.AspNetCore.WeChatPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.WeChatPay
{
    public class WeChatPayNotifyClient
    {
        public WeChatPayOptions Options { get; set; }

        public WeChatPayNotifyClient(WeChatPayOptions options)
        {
            Options = options;
        }

        public WeChatPayNotifyClient(IOptions<WeChatPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new WeChatPayOptions())
        {
        }

        public WeChatPayNotifyClient(string key)
            : this(new WeChatPayOptions { Key = key })
        {
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotifyResponse
        {
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            var parser = new WeChatPayXmlParser<T>();
            var rsp = parser.Parse(body);
            if (rsp is WeChatPayRefundNotifyResponse)
            {
                var key = MD5.Compute(Options.Key).ToLower();
                var data = AES.Decrypt(rsp.ReqInfo, key); // AES-256-ECB
                rsp = parser.Parse(rsp, data);
                rsp.Body = data;
            }
            else
            {
                CheckNotifySign(rsp);
                rsp.Body = body;
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

            var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, Options.Key);
            if (cal_sign != sign)
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }
    }
}