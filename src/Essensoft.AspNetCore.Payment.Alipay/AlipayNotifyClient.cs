using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
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
        private RSAParameters RSAPublicParameters;

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

            RSAPublicParameters = AlipaySignature.GetPublicParameters(Options.RsaPublicKey);
        }

        public Task<T> ExecuteAsync<T>(HttpRequest request) where T : AlipayNotifyResponse
        {
            var parameters = GetParameters(request);
            var parser = new AlipayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);

            var query = HttpClientEx.BuildQuery(parameters);
            Logger.LogInformation(0, "Request Content:{query}", query);

            CheckNotifySign(parameters, RSAPublicParameters, Options.SignType);
            return Task.FromResult(rsp);
        }

        private SortedDictionary<string, string> GetParameters(HttpRequest request)
        {
            var parameters = new SortedDictionary<string, string>();
            if (request.Method == "POST")
            {
                foreach (var item in request.Form)
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

        private void CheckNotifySign(IDictionary<string, string> content, RSAParameters parameters, string signType)
        {
            if (content.Count == 0)
            {
                throw new AlipayException("sign check fail: content is Empty!");
            }

            var sign = content["sign"];
            if (string.IsNullOrEmpty(sign))
            {
                throw new AlipayException("sign check fail: sign is Empty!");
            }

            var prestr = GetSignContent(content);
            if (!AlipaySignature.RSACheckContent(prestr, sign, parameters, signType))
            {
                throw new AlipayException("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        private string GetSignContent(IDictionary<string, string> parameters)
        {
            var content = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (iter.Key.ToLower() != "sign" && iter.Key.ToLower() != "sign_type" && !string.IsNullOrEmpty(iter.Value))
                {
                    content.Append(iter.Key + "=" + iter.Value + "&");
                }
            }
            return content.ToString().Substring(0, content.Length - 1);
        }
    }
}