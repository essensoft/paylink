using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayMobilePublicMultiMediaClient : IAlipayMobilePublicMultiMediaClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        #region AlipayMobilePublicMultiMediaClient Constructors

        public AlipayMobilePublicMultiMediaClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        #endregion

        public Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return ExecuteAsync(request, options, null);
        }

        public Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse
        {
            return ExecuteAsync(request, options, accessToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new AlipayException("options.AppId is Empty!");
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException("options.SignType is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new AlipayException("options.AppPrivateKey is Empty!");
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new AlipayException("options.ServerUrl is Empty!");
            }

            var multiMediaDownloadRequest = (AlipayMobilePublicMultiMediaDownloadRequest)request;

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { AlipayConstants.METHOD, request.GetApiName() },
                { AlipayConstants.VERSION, apiVersion },
                { AlipayConstants.APP_ID, options.AppId },
                { AlipayConstants.FORMAT, options.Format },
                { AlipayConstants.TIMESTAMP, DateTime.Now },
                { AlipayConstants.ACCESS_TOKEN, accessToken },
                { AlipayConstants.APP_AUTH_TOKEN, appAuthToken },
                { AlipayConstants.SIGN_TYPE, options.SignType },
                { AlipayConstants.TERMINAL_TYPE, request.GetTerminalType() },
                { AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo() },
                { AlipayConstants.PROD_CODE, request.GetProdCode() }
            };

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(AlipayConstants.SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            var url = options.ServerUrl;
            if (txtParams != null && txtParams.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + AlipayUtility.BuildQuery(txtParams);
                }
                else
                {
                    url = url + "?" + AlipayUtility.BuildQuery(txtParams);
                }
            }

            var client = _httpClientFactory.CreateClient(nameof(AlipayMobilePublicMultiMediaClient));

            T response = null;
            var rsp = await client.GetAsync(url);
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                if (rsp.Content.Headers.ContentType.ToString().ToLower().Contains("text/plain"))
                {
                    var body = await rsp.Content.ReadAsStringAsync();
                    var tp = new AlipayJsonParser<T>();
                    response = tp.Parse(body);
                }
                else
                {
                    multiMediaDownloadRequest.Stream = await rsp.Content.ReadAsStreamAsync();
                    response = Activator.CreateInstance<T>();
                }
            }

            return response;
        }
    }
}
