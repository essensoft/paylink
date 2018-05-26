using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayNotifyClient : IQPayNotifyClient
    {
        public QPayOptions Options { get; }

        public virtual ILogger Logger { get; set; }

        #region QPayNotifyClient

        public QPayNotifyClient(
            IOptions<QPayOptions> optionsAccessor,
            ILogger<QPayNotifyClient> logger)
        {
            Options = optionsAccessor.Value;
            Logger = logger;

            if (string.IsNullOrEmpty(Options.Key))
            {
                throw new ArgumentNullException(nameof(Options.Key));
            }
        }

        public QPayNotifyClient(IOptions<QPayOptions> optionsAccessor)
            : this(optionsAccessor, null)
        { }
        
        #endregion

        #region IQPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : QPayNotifyResponse
        {
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            Logger?.LogTrace(0, "Request:{body}", body);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckNotifySign(rsp);
            return rsp;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(QPayNotifyResponse response)
        {
            if (response?.Parameters?.Count == 0)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            if (!response.Parameters.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var cal_sign = QPaySignature.SignWithKey(response.Parameters, Options.Key);
            if (cal_sign != sign)
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
