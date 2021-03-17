using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Essensoft.Paylink.Alipay.Parser;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay
{
    public class AlipayNotifyClient : IAlipayNotifyClient
    {
        #region AlipayNotifyClient Constructors

        public AlipayNotifyClient()
        {

        }

        #endregion

        #region IAlipayNotifyClient Members

#if NETCOREAPP3_1 || NET5_0
        public async Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, AlipayOptions options) where T : AlipayNotify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AlipayPublicKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AlipayPublicKey)} is Empty!");
            }

            var parameters = await GetParametersAsync(request);
            return await ExecuteAsync<T>(parameters, options);
        }
#endif

        #endregion

        #region IAlipayNotifyClient Members

#if NETCOREAPP3_1 || NET5_0
        public Task<T> CertificateExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, AlipayOptions options) where T : AlipayNotify
        {
            return ExecuteAsync<T>(request, options);
        }
#endif

        #endregion

        #region IAlipayNotifyClient Members

#if NETCOREAPP3_1 || NET5_0
        public async Task<IDictionary<string, string>> GetParametersAsync(Microsoft.AspNetCore.Http.HttpRequest request)
        {
            var parameters = new Dictionary<string, string>();
            if (request.Method == "POST")
            {
                var form = await request.ReadFormAsync();
                foreach (var iter in form)
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
#endif

        #endregion

        #region IAlipayNotifyClient Members

        public Task<T> ExecuteAsync<T>(IDictionary<string, string> parameters, AlipayOptions options) where T : AlipayNotify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AlipayPublicKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AlipayPublicKey)} is Empty!");
            }

            var notify = AlipayDictionaryParser.Parse<T>(parameters);
            CheckNotifySign(parameters, options);
            return Task.FromResult(notify);
        }

        #endregion

        #region IAlipayNotifyClient Members

        public Task<T> CertificateExecuteAsync<T>(IDictionary<string, string> parameters, AlipayOptions options) where T : AlipayNotify
        {
            return ExecuteAsync<T>(parameters, options);
        }

        #endregion

        #region Common Method

        private static void CheckNotifySign(IDictionary<string, string> dictionary, AlipayOptions options)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new AlipayException("sign check fail: dictionary)} is Empty!");
            }

            if (!dictionary.TryGetValue(AlipayConstants.SIGN, out var sign))
            {
                throw new AlipayException("sign check fail: sign)} is Empty!");
            }

            dictionary.Remove(AlipayConstants.SIGN);
            dictionary.Remove(AlipayConstants.SIGN_TYPE);
            var content = AlipaySignature.GetSignContent(dictionary);
            if (!AlipaySignature.RSACheckContent(content, sign, options.AlipayPublicKey, options.SignType))
            {
                throw new AlipayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
