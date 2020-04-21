#if NETCOREAPP3_1

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayNotifyClient : IAlipayNotifyClient
    {
        #region AlipayNotifyClient Constructors

        public AlipayNotifyClient()
        {

        }

        #endregion

        #region IAlipayNotifyClient Members

        public Task<T> ExecuteAsync<T>(HttpRequest request, AlipayOptions options) where T : AlipayNotify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new ArgumentNullException(nameof(options.SignType));
            }

            if (string.IsNullOrEmpty(options.AlipayPublicKey))
            {
                throw new ArgumentNullException(nameof(options.AlipayPublicKey));
            }

            var parameters = GetParameters(request);
            var rsp = AlipayDictionaryParser.Parse<T>(parameters);
            CheckNotifySign(parameters, options);
            return Task.FromResult(rsp);
        }

        #endregion

        #region IAlipayNotifyClient Members

        public Task<T> CertificateExecuteAsync<T>(HttpRequest request, AlipayOptions options) where T : AlipayNotify
        {
            return ExecuteAsync<T>(request, options);
        }

        #endregion

        #region IAlipayNotifyClient Members

        public IDictionary<string, string> GetParameters(HttpRequest request)
        {
            var parameters = new Dictionary<string, string>();
            if (request.Method == "POST")
            {
                foreach (var iter in request.Form)
                {
                    parameters.Add(iter.Key, iter.Value);
                }
            }
            else
            {
                foreach (var iter in request.Query)
                {
                    parameters.Add(iter.Key, iter.Value);
                }
            }
            return parameters;
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(IDictionary<string, string> dictionary, AlipayOptions options)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new AlipayException("sign check fail: dictionary is Empty!");
            }

            if (!dictionary.TryGetValue(AlipayConstants.SIGN, out var sign))
            {
                throw new AlipayException("sign check fail: sign is Empty!");
            }

            dictionary.Remove(AlipayConstants.SIGN);
            dictionary.Remove(AlipayConstants.SIGN_TYPE);
            var prestr = AlipaySignature.GetSignContent(dictionary);
            if (!AlipaySignature.RSACheckContent(prestr, sign, options.AlipayPublicKey, options.Charset, options.SignType))
            {
                throw new AlipayException("sign check fail: check Sign Data Fail!");
            }
        }

        #endregion
    }
}

#endif
