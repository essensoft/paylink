using Essensoft.AspNetCore.Alipay.Parser;
using Essensoft.AspNetCore.Alipay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Alipay
{
    public class AlipayNotifyClient
    {
        public AlipayOptions Options { get; set; }
        public AlipayNotifyClient(IOptions<AlipayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new AlipayOptions();
        }

        public AlipayNotifyClient(string signType, string alipayPublicKey)
            : this(null)
        {
            Options.SignType = signType;
            Options.RsaPublicKey = alipayPublicKey;
        }

        public T Execute<T>(HttpRequest request) where T : AlipayObject
        {
            var parameters = GetParameters(request);
            var parser = new AlipayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);

            CheckNotifySign(parameters, Options.RsaPublicKey, Options.SignType);
            return rsp;
        }

        private SortedDictionary<string, string> GetParameters(HttpRequest request)
        {
            var parameters = new SortedDictionary<string, string>();
            if (request.Method == "POST")
            {
                foreach (var item in request?.Form)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            else if (request.Method == "GET")
            {
                foreach (var item in request?.Query)
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            return parameters;
        }

        private void CheckNotifySign(IDictionary<string, string> parameters, string alipayPublicKey, string signType)
        {
            if (parameters.Count == 0)
            {
                throw new AlipayException("sign check fail: Body is Empty!");
            }

            var sign = parameters["sign"];
            if (!string.IsNullOrEmpty(sign))
            {
                var prestr = GetSignContent(parameters);
                if (!AlipaySignature.RSACheckContent(prestr, sign, alipayPublicKey, signType))
                {
                    throw new AlipayException("sign check fail: check Sign and Data Fail JSON also");
                }
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