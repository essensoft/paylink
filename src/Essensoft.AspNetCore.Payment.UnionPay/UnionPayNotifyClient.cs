using Essensoft.AspNetCore.Payment.UnionPay.Parser;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public class UnionPayNotifyClient
    {
        private UnionPayCertificate MiddleCertificate;
        private UnionPayCertificate RootCertificate;

        public UnionPayOptions Options { get; set; }

        public virtual ILogger<UnionPayNotifyClient> Logger { get; set; }

        public UnionPayNotifyClient(
            IOptions<UnionPayOptions> optionsAccessor, 
            ILogger<UnionPayNotifyClient> logger)
        {
            Options = optionsAccessor?.Value ?? new UnionPayOptions();
            Logger = logger;

            if (string.IsNullOrEmpty(Options.MiddleCert))
            {
                throw new ArgumentNullException(nameof(Options.MiddleCert));
            }

            if (string.IsNullOrEmpty(Options.RootCert))
            {
                throw new ArgumentNullException(nameof(Options.RootCert));
            }

            MiddleCertificate = UnionPaySignature.GetCertificate(Options.MiddleCert);
            RootCertificate = UnionPaySignature.GetCertificate(Options.RootCert);
        }

        public Task<T> ExecuteAsync<T>(HttpRequest request) where T : UnionPayNotifyResponse
        {
            var parameters = GetParameters(request);

            var query = HttpClientEx.BuildQuery(parameters);
            Logger.LogInformation(0, "Request Content:{query}", query);

            var parser = new UnionPayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            CheckNotifySign(parameters);
            return Task.FromResult(rsp);
        }

        private UnionPayDictionary GetParameters(HttpRequest request)
        {
            var parameters = new UnionPayDictionary();
            if (request.Method == "POST")
            {
                foreach (var item in request.Form)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            return parameters;
        }

        private void CheckNotifySign(UnionPayDictionary dic)
        {
            if (dic == null || dic.Count == 0)
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var ifValidateCNName = !Options.TestMode;
            if (!UnionPaySignature.Validate(dic, RootCertificate.cert, MiddleCertificate.cert, Options.SecureKey, ifValidateCNName))
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }
    }
}
