using System;
using System.IO;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayNotifyClient : ILianLianPayNotifyClient
    {
        #region LianLianPayNotifyClient Constructors

        public LianLianPayNotifyClient(
            ILogger<LianLianPayClient> logger,
            IOptionsSnapshot<LianLianPayOptions> optionsAccessor)
        {
            Logger = logger;
            OptionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        public virtual ILogger Logger { get; set; }

        public virtual IOptionsSnapshot<LianLianPayOptions> OptionsSnapshotAccessor { get; set; }

        #region ILianLianPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotifyResponse
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : LianLianPayNotifyResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            if (request.HasFormContentType)
            {
                var parameters = await GetParametersAsync(request);
                var query = LianLianPayUtility.BuildQuery(parameters);
                Logger?.LogTrace(0, "Request:{query}", query);

                var parser = new LianLianPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);
                CheckNotifySign(parameters, options);
                return rsp;
            }

            if (request.HasTextJsonContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger?.LogTrace(0, "Request:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);
                CheckNotifySign(rsp.Parameters, options);
                return rsp;
            }

            throw new Exception("content type is not supported");
        }

        #endregion

        #region Common Method

        private async Task<LianLianPayDictionary> GetParametersAsync(HttpRequest request)
        {
            var parameters = new LianLianPayDictionary();
            var form = await request.ReadFormAsync();
            foreach (var iter in form)
            {
                parameters.Add(iter.Key, iter.Value);
            }
            return parameters;
        }

        private void CheckNotifySign(LianLianPayDictionary para, LianLianPayOptions options)
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
            if (!MD5WithRSA.VerifyData(prestr, sign, options.PublicKey))
            {
                throw new Exception("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        #endregion
    }
}
