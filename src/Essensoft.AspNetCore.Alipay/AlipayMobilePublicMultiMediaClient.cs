using Essensoft.AspNetCore.Alipay.Parser;
using Essensoft.AspNetCore.Alipay.Request;
using Essensoft.AspNetCore.Alipay.Response;
using Essensoft.AspNetCore.Alipay.Utility;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Alipay
{
    public class AlipayMobilePublicMultiMediaClient : IAlipayClient
    {
        private const string APP_ID = "app_id";
        private const string FORMAT = "format";
        private const string METHOD = "method";
        private const string TIMESTAMP = "timestamp";
        private const string VERSION = "version";
        private const string SIGN_TYPE = "sign_type";
        private const string ACCESS_TOKEN = "auth_token";
        private const string SIGN = "sign";
        private const string TERMINAL_TYPE = "terminal_type";
        private const string TERMINAL_INFO = "terminal_info";
        private const string PROD_CODE = "prod_code";
        private const string APP_AUTH_TOKEN = "app_auth_token";

        private RSAParameters RSAPrivateParameters;

        public AlipayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        #region AlipayClient Constructors

        public AlipayMobilePublicMultiMediaClient(AlipayOptions options)
        {
            Options = options;
            Client = new HttpClientEx();

            if (!string.IsNullOrEmpty(Options.RsaPrivateKey))
            {
                RSAPrivateParameters = AlipaySignature.GetPrivateParameters(Options.RsaPrivateKey);
            }
        }

        public AlipayMobilePublicMultiMediaClient(IOptions<AlipayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new AlipayOptions())
        {
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey)
        : this(new AlipayOptions { AppId = appId, RsaPrivateKey = privateKey, ServerUrl = serverUrl })
        {
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey, string format)
            : this(new AlipayOptions { AppId = appId, RsaPrivateKey = privateKey, ServerUrl = serverUrl, Format = format })
        {
        }

        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKey, string format, string version, string signType)
            : this(new AlipayOptions { AppId = appId, RsaPrivateKey = privateKey, ServerUrl = serverUrl, Format = format, Version = version, SignType = signType })
        {
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
            txtParams.Add(SIGN, AlipaySignature.RSASign(txtParams, RSAPrivateParameters, Options.SignType));

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
                if (clientResponse.StatusCode == HttpStatusCode.OK)
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
        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }
    }
}
