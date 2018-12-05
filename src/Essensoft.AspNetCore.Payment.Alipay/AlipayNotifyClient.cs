using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 通知解析客户端。
    /// </summary>
    public class AlipayNotifyClient : IAlipayNotifyClient
    {
        private readonly ILogger _logger;
        private readonly IOptionsSnapshot<AlipayOptions> _optionsSnapshotAccessor;

        #region AlipayNotifyClient Constructors

        public AlipayNotifyClient(
            ILogger<AlipayNotifyClient> logger,
            IOptionsSnapshot<AlipayOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IAlipayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : AlipayNotify
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : AlipayNotify
        {
            var options = _optionsSnapshotAccessor.Get(optionsName);
            var parameters = await GetParametersAsync(request);
            var query = AlipayUtility.BuildQuery(parameters);
            _logger.Log(options.LogLevel, "Request:{query}", query);

            var parser = new AlipayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            CheckNotifySign(parameters, options.PublicRSAParameters, options.SignType);
            return rsp;
        }

        #endregion

        #region Common Method

        private async Task<SortedDictionary<string, string>> GetParametersAsync(HttpRequest request)
        {
            var parameters = new SortedDictionary<string, string>();
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

        private void CheckNotifySign(IDictionary<string, string> parameters, RSAParameters publicRSAParameters, string signType)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new AlipayException("sign check fail: content is Empty!");
            }

            if (!parameters.TryGetValue("sign", out var sign))
            {
                throw new AlipayException("sign check fail: sign is Empty!");
            }

            var prestr = GetSignContent(parameters);
            if (!AlipaySignature.RSACheckContent(prestr, sign, publicRSAParameters, signType))
            {
                throw new AlipayException("sign check fail: check Sign Data Fail!");
            }
        }

        private string GetSignContent(IDictionary<string, string> parameters)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var sb = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && iter.Key != "sign_type")
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        #endregion
    }
}