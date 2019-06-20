using Essensoft.AspNetCore.UnionPay.Parser;
using Essensoft.AspNetCore.UnionPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Essensoft.AspNetCore.UnionPay
{
    public class UnionPayNotifyClient
    {
        public UnionPayOptions Options { get; set; }

        public UnionPayNotifyClient(UnionPayOptions options)
        {
            Options = options;
        }

        public UnionPayNotifyClient(IOptionsMonitor<UnionPayOptions> optionsAccessor, ILogger<UnionPayNotifyClient> logger) : this(optionsAccessor?.CurrentValue ?? new UnionPayOptions())
        {
            optionsAccessor.OnChange(newOption =>
            {
                if (newOption.Equals(Options))
                    return;
                Options = newOption;
                logger.LogDebug($"{nameof(UnionPayOptions)}配置已更新");
            });
        }

        public Task<T> ExecuteAsync<T>(HttpRequest request) where T : UnionPayNotifyResponse
        {
            var parameters = new UnionPayDictionary();

            if (request.Method == "POST")
            {
                foreach (var item in request.Form)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }

            if (parameters == null || parameters.Count == 0)
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            if (!UnionPaySignature.Validate(parameters, Options.SecureKey))
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }

            var parser = new UnionPayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            return Task.FromResult(rsp);
        }

    }
}
