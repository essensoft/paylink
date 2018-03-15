using Essensoft.AspNetCore.QPay.Parser;
using Essensoft.AspNetCore.QPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.QPay
{
    public class QPayNotifyClient
    {
        public QPayOptions Options { get; set; }

        public QPayNotifyClient(QPayOptions options)
        {
            Options = options;
        }

        public QPayNotifyClient(IOptions<QPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new QPayOptions())
        {
        }

        public QPayNotifyClient(string key)
            : this(new QPayOptions { Key = key })
        {
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : QPayNotifyResponse
        {
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckNotifySign(rsp);
            rsp.Body = body;
            return rsp;
        }

        private void CheckNotifySign(QPayNotifyResponse response)
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

            var cal_sign = QPaySignature.SignWithKey(response.Parameters, Options.Key);
            if (cal_sign != sign)
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }
    }
}
