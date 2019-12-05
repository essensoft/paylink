#if NETCOREAPP3_1

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay.Parser;
using Essensoft.AspNetCore.Payment.QPay.Utility;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayNotifyClient : IQPayNotifyClient
    {
        #region QPayNotifyClient Constructors

        public QPayNotifyClient()
        {
        }

        #endregion

        #region IQPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request, QPayOptions options) where T : QPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();

            var parser = new QPayXmlParser<T>();
            var rsp = parser.Parse(body);
            CheckNotifySign(rsp, options);
            return rsp;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(QPayNotify response, QPayOptions options)
        {
            if (string.IsNullOrEmpty(response.ResponseBody))
            {
                throw new QPayException("sign check fail: Body is Empty!");
            }

            if (response.ResponseParameters.Count == 0)
            {
                throw new QPayException("sign check fail: Parameters is Empty!");
            }

            if (!response.ResponseParameters.TryGetValue("sign", out var sign))
            {
                throw new QPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = QPaySignature.SignWithKey(response.ResponseParameters, options.Key);
            if (cal_sign != sign)
            {
                throw new QPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}

#endif
