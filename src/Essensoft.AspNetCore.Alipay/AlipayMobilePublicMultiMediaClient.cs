using Essensoft.AspNetCore.Alipay.Parser;
using Essensoft.AspNetCore.Alipay.Request;
using Essensoft.AspNetCore.Alipay.Response;
using Essensoft.AspNetCore.Alipay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Alipay
{
    public class AlipayMobilePublicMultiMediaClient : IAlipayClient
    {

        public const string APP_ID = "app_id";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "version";
        public const string SIGN_TYPE = "sign_type";
        public const string ACCESS_TOKEN = "auth_token";
        public const string SIGN = "sign";
        public const string TERMINAL_TYPE = "terminal_type";
        public const string TERMINAL_INFO = "terminal_info";
        public const string PROD_CODE = "prod_code";
        public const string APP_AUTH_TOKEN = "app_auth_token";

        public AlipayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        #region AlipayClient Constructors

        public AlipayMobilePublicMultiMediaClient(IOptions<AlipayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new AlipayOptions();
            Client = new HttpClientEx();
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey)
            : this(null)
        {
            Options.AppId = appId;
            Options.RsaPrivateKey = privateKey;
            Options.ServerUrl = serverUrl;
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey, string format)
            : this(serverUrl, appId, privateKey)
        {
            Options.Format = format;
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey, string format, string version, string signType)
            : this(serverUrl, appId, privateKey, format)
        {
            Options.Version = version;
            Options.SignType = signType;
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string accessToken) where T : AlipayResponse
        {

            return await ExecuteAsync<T>(request, accessToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken) where T : AlipayResponse
        {

            var multiMediaDownloadRequest = ((AlipayMobilePublicMultiMediaDownloadRequest)request);
            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { METHOD, request.GetApiName() },
                { VERSION, Options.Version },
                { APP_ID, Options.AppId },
                { FORMAT, Options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, Options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() }
            };

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);
            }

            // 添加签名参数
            txtParams.Add(SIGN, AlipaySignature.RSASign(txtParams, Options.RsaPrivateKey, Options.SignType));

            var outStream = multiMediaDownloadRequest.Stream;
            var rsp = await DoGetAsync(txtParams, outStream);

            return (T)rsp;

        }

        #endregion

        private async Task<AlipayResponse> DoGetAsync(AlipayDictionary parameters, Stream outStream)
        {
            AlipayMobilePublicMultiMediaDownloadResponse response = null;

            var url = Options.ServerUrl;
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + HttpClientEx.BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + HttpClientEx.BuildQuery(parameters);
                }
            }


            using (var clientResponse = await Client.GetAsync(url))
            {
                if (clientResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    using (var content = clientResponse.Content)
                    {
                        if (content.Headers.ContentType.ToString().ToLower().Contains("text/plain"))
                        {
                            var body = await content.ReadAsStringAsync();
                            IAlipayParser<AlipayMobilePublicMultiMediaDownloadResponse> tp = new AlipayJsonParser<AlipayMobilePublicMultiMediaDownloadResponse>();
                            response = tp.Parse(body);
                        }
                        else
                        {
                            outStream = await content.ReadAsStreamAsync();
                            response = new AlipayMobilePublicMultiMediaDownloadResponse();
                        }
                    }
                }
            }

            return response;
        }

        public Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }

        public Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string session, string reqMethod) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }

        public T SdkExecute<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }
    }
}
