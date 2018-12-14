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
    /// <summary>
    /// LianLianPay 通知解析客户端。
    /// </summary>
    public class LianLianPayNotifyClient : ILianLianPayNotifyClient
    {
        private readonly ILogger _logger;
        private readonly IOptionsSnapshot<LianLianPayOptions> _optionsSnapshotAccessor;

        #region LianLianPayNotifyClient Constructors

        public LianLianPayNotifyClient(
            ILogger<LianLianPayClient> logger,
            IOptionsSnapshot<LianLianPayOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region ILianLianPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotify
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : LianLianPayNotify
        {
            var options = string.IsNullOrEmpty(optionsName) ? _optionsSnapshotAccessor.Value : _optionsSnapshotAccessor.Get(optionsName);
            if (request.HasFormContentType)
            {
                var parameters = await GetParametersAsync(request);
                var query = LianLianPayUtility.BuildQuery(parameters);
                _logger.Log(options.LogLevel, "Request:{query}", query);

                var parser = new LianLianPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);
                CheckNotifySign(parameters, options);
                return rsp;
            }

            if (request.HasTextJsonContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                _logger.Log(options.LogLevel, "Request:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);
                CheckNotifySign(rsp.Parameters, options);
                return rsp;
            }

            throw new LianLianPayException("content type is not supported");
        }

        #endregion

        #region Common Method

        private async Task<LianLianPayDictionary> GetParametersAsync(HttpRequest request)
        {
            var dictionary = new LianLianPayDictionary();
            var formCollection = await request.ReadFormAsync();
            foreach (var iter in formCollection)
            {
                dictionary.Add(iter.Key, iter.Value);
            }
            return dictionary;
        }

        private void CheckNotifySign(LianLianPayDictionary dictionary, LianLianPayOptions options)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new LianLianPayException("sign check fail: dictionary is Empty!");
            }

            if (!dictionary.TryGetValue("sign", out var sign))
            {
                throw new LianLianPayException("sign check fail: sign is Empty!");
            }

            var prestr = LianLianPaySecurity.GetSignContent(dictionary);
            if (!MD5WithRSA.VerifyData(prestr, sign, options.PublicKey))
            {
                throw new LianLianPayException("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        #endregion
    }
}
