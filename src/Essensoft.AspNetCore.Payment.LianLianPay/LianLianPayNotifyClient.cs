using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayNotifyClient : ILianLianPayNotifyClient
    {
        private AsymmetricKeyParameter PublicKey;

        public LianLianPayOptions Options { get; set; }

        public virtual ILogger Logger { get; set; }

        #region LianLianPayNotifyClient Constructors

        public LianLianPayNotifyClient(
            IOptions<LianLianPayOptions> optionsAccessor,
            ILogger<LianLianPayClient> logger)
        {
            Options = optionsAccessor?.Value;
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

            PublicKey = RSAUtilities.GetKeyParameterFormPublicKey(Options.RsaPublicKey);
        }

        public LianLianPayNotifyClient(IOptions<LianLianPayOptions> optionsAccessor)
            : this(optionsAccessor, null)
        { }

        #endregion

        #region ILianLianPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotifyResponse
        {
            if (request.HasFormContentType)
            {
                var parameters = await GetParametersAsync(request);
                var query = HttpClientEx.BuildQuery(parameters);
                Logger?.LogTrace(0, "Request:{query}", query);

                var parser = new LianLianPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);
                CheckNotifySign(parameters);
                return rsp;
            }
            else if (request.HasTextJsonContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger?.LogTrace(0, "Request:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);
                CheckNotifySign(rsp.Parameters);
                return rsp;
            }
            else
            {
                throw new Exception("Content type is not supported");
            }
        }

        #endregion

        #region Common Method

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

        private void CheckNotifySign(LianLianPayDictionary para)
        {
            if (para.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (!para.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var prestr = LianLianPaySecurity.GetSignContent(para);
            if (!MD5WithRSA.VerifyData(prestr, sign, PublicKey))
            {
                throw new Exception("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        #endregion
    }
}
