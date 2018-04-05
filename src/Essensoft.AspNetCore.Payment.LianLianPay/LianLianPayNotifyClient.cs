using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayNotifyClient
    {
        private RSAParameters RSAPublicParameters;

        public LianLianPayOptions Options { get; set; }

        public virtual ILogger<LianLianPayClient> Logger { get; set; }

        public LianLianPayNotifyClient(
            IOptions<LianLianPayOptions> optionsAccessor,
            ILogger<LianLianPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new LianLianPayOptions();
            Logger = logger;

            if (string.IsNullOrEmpty(Options.OidPartner))
            {
                throw new ArgumentNullException(nameof(Options.OidPartner));
            }

            if (string.IsNullOrEmpty(Options.BusiPartner))
            {
                throw new ArgumentNullException(nameof(Options.BusiPartner));
            }

            if (string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPublicKey));
            }

            RSAPublicParameters = LianLianPaySignature.GetPublicParameters(Options.RsaPublicKey);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotifyResponse
        {
            if (request.HasFormContentType)
            {
                var parameters = await GetParametersAsync(request);
                var query = HttpClientEx.BuildQuery(parameters);
                Logger.LogInformation(0, "Request:{query}", query);

                var parser = new LianLianPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);
                CheckNotifySign(parameters, RSAPublicParameters);
                return rsp;
            }
            else if (request.HasTextJsonContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger.LogInformation(0, "Request:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);
                CheckNotifySign(rsp.Parameters, RSAPublicParameters);
                return rsp;
            }
            else
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }

        private async Task<LianLianPayDictionary> GetParametersAsync(HttpRequest request)
        {
            var parameters = new LianLianPayDictionary();
            var form = await request.ReadFormAsync();
            foreach (var item in form)
            {
                parameters.Add(item.Key, item.Value);
            }
            return parameters;
        }

        private void CheckNotifySign(LianLianPayDictionary para, RSAParameters parameters)
        {
            if (para.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (!para.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var prestr = LianLianPaySignature.GetSignContent(para);
            if (!LianLianPaySignature.RSACheckContent(prestr, sign, parameters))
            {
                throw new Exception("sign check fail: check Sign and Data Fail JSON also");
            }
        }
    }
}
