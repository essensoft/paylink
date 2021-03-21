using System;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.Paylink.WeChatPay.V2.Extensions;
using Essensoft.Paylink.WeChatPay.V2.Parser;

namespace Essensoft.Paylink.WeChatPay.V2
{
    public class WeChatPayClient : IWeChatPayClient
    {
        public const string Name = "WeChatPay.V2.Client";
        public const string Prefix = Name + ".";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly WeChatPayClientCertificateManager _clientCertificateManager;

        #region WeChatPayClient Constructors

        public WeChatPayClient(IHttpClientFactory httpClientFactory, WeChatPayClientCertificateManager clientCertificateManager)
        {
            _httpClientFactory = httpClientFactory;
            _clientCertificateManager = clientCertificateManager;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIKey)} is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            request.PrimaryHandler(sortedTxtParams, options);

            var client = _httpClientFactory.CreateClient(Name);
            var body = await client.PostAsync(request, sortedTxtParams);
            var parser = new WeChatPayResponseXmlParser<T>();
            var response = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                var signType = request.GetSignType();
                CheckResponseSign(response, options, signType);
            }

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public Task<T> PageExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIKey)} is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            request.PrimaryHandler(sortedTxtParams, options);

            var url = request.GetRequestUrl();
            if (url.Contains("?"))
            {
                url += "&" + WeChatPayUtility.BuildQuery(sortedTxtParams);
            }
            else
            {
                url += "?" + WeChatPayUtility.BuildQuery(sortedTxtParams);
            }

            var rsp = Activator.CreateInstance<T>();
            rsp.Body = url;
            return Task.FromResult(rsp);
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.Certificate)} is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            request.PrimaryHandler(sortedTxtParams, options);

            if (!_clientCertificateManager.ContainsKey(options.CertificateSerialNo))
            {
                _clientCertificateManager.TryAdd(options.CertificateSerialNo, options.Certificate2);
            }

            var client = _httpClientFactory.CreateClient(Prefix + options.CertificateSerialNo);
            var body = await client.PostAsync(request, sortedTxtParams);
            var parser = new WeChatPayResponseXmlParser<T>();
            var response = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                var signType = request.GetSignType();
                CheckResponseSign(response, options, signType);
            }

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public Task<WeChatPayDictionary> ExecuteAsync(IWeChatPaySdkRequest request, WeChatPayOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIKey)} is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());
            request.PrimaryHandler(sortedTxtParams, options);

            return Task.FromResult(sortedTxtParams);
        }

        #endregion

        #region Check Response Method

        private static void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options, WeChatPaySignType signType)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.TryGetValue(WeChatPayConsts.return_code, out var return_code))
            {
                if (return_code == WeChatPayCode.Success)
                {
                    if (!response.Parameters.TryGetValue(WeChatPayConsts.sign, out var sign))
                    {
                        throw new WeChatPayException("sign check fail: sign is Empty!");
                    }

                    var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, options.APIKey, signType);
                    if (cal_sign != sign)
                    {
                        throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
                    }
                }
            }
        }

        #endregion
    }
}
