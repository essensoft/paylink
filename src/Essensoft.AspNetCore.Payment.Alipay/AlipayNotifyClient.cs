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
    public class AlipayNotifyClient
    {
        private RSAParameters PublicRSAParameters;

        public AlipayOptions Options { get; set; }

        public virtual ILogger<AlipayNotifyClient> Logger { get; set; }

        public AlipayNotifyClient(
            IOptions<AlipayOptions> optionsAccessor,
            ILogger<AlipayNotifyClient> logger)
        {
            Options = optionsAccessor?.Value ?? new AlipayOptions();
            Logger = logger;

            if (string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPublicKey));
            }

            PublicRSAParameters = RSAUtilities.GetRSAParametersFormPublicKey(Options.RsaPublicKey);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : AlipayNotifyResponse
        {
            var parameters = await GetParametersAsync(request);
            var query = HttpClientEx.BuildQuery(parameters);
            Logger.LogInformation(0, "Request:{query}", query);

            var parser = new AlipayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            CheckNotifySign(parameters, PublicRSAParameters, Options.SignType);
            return rsp;
        }

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

        private void CheckNotifySign(IDictionary<string, string> para, RSAParameters parameters, string signType)
        {
            if (para.Count == 0)
            {
                throw new AlipayException("sign check fail: content is Empty!");
            }

            if (!para.TryGetValue("sign", out var sign))
            {
                throw new AlipayException("sign check fail: sign is Empty!");
            }

            var prestr = GetSignContent(para);
            if (!AlipaySignature.RSACheckContent(prestr, sign, parameters, signType))
            {
                throw new AlipayException("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        private string GetSignContent(IDictionary<string, string> para)
        {
            if (para == null || para.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            foreach (var iter in para)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && iter.Key != "sign_type")
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }
    }
}