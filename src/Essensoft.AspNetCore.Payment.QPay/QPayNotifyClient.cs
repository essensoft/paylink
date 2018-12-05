using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.QPay
{
    /// <summary>
    /// QPay 通知解析客户端。
    /// </summary>
    public class QPayNotifyClient : IQPayNotifyClient
    {
        private readonly ILogger _logger;
        private readonly IOptionsSnapshot<QPayOptions> _optionsSnapshotAccessor;

        #region QPayNotifyClient Constructors

        public QPayNotifyClient(
            ILogger<QPayNotifyClient> logger,
            IOptionsSnapshot<QPayOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IQPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : QPayNotify
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : QPayNotify
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            _logger.Log(options.LogLevel, "Request:{body}", body);

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckNotifySign(rsp, options);
            return rsp;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(QPayNotify response, QPayOptions options)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new QPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new QPayException("sign check fail: Parameters is Empty!");
            }

            if (!response.Parameters.TryGetValue("sign", out var sign))
            {
                throw new QPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = QPaySignature.SignWithKey(response.Parameters, options.Key);
            if (cal_sign != sign)
            {
                throw new QPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
