using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayNotifyClient : IAlipayNotifyClient
    {
        private RSAParameters PublicRSAParameters;

        public AlipayOptions Options { get; set; }

        public virtual ILogger Logger { get; set; }

        #region AlipayNotifyClient Constructors

        public AlipayNotifyClient(
            IOptions<AlipayOptions> optionsAccessor,
            ILogger<AlipayNotifyClient> logger)
        {
            Options = optionsAccessor.Value;
            Logger = logger;

            if (string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPublicKey));
            }

            PublicRSAParameters = RSAUtilities.GetRSAParametersFormPublicKey(Options.RsaPublicKey);
        }

        public AlipayNotifyClient(IOptions<AlipayOptions> optionsAccessor)
            : this(optionsAccessor, null)
        { }

        #endregion

        #region IAlipayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : AlipayNotifyResponse
        {
            var parameters = await GetParametersAsync(request);
            var query = HttpClientEx.BuildQuery(parameters);
            Logger?.LogTrace(0, "Request:{query}", query);

            var parser = new AlipayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            CheckNotifySign(parameters, PublicRSAParameters, Options.SignType);
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
                foreach (var item in form)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            else
            {
                foreach (var item in request.Query)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            return parameters;
        }

        private void CheckNotifySign(IDictionary<string, string> parameters, RSAParameters publicRSAParameters, string signType)
        {
            if (parameters == null || parameters.Count == 0)
            {
                throw new Exception("sign check fail: content is Empty!");
            }

            if (!parameters.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var prestr = GetSignContent(parameters);
            if (!AlipaySignature.RSACheckContent(prestr, sign, publicRSAParameters, signType))
            {
                throw new Exception("sign check fail: check Sign and Data Fail JSON also");
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
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        #endregion
    }
}