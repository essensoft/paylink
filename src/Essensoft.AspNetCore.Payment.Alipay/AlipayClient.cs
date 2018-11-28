using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay客户端。
    /// </summary>
    public class AlipayClient : IAlipayClient
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
        private const string NOTIFY_URL = "notify_url";
        private const string CHARSET = "charset";
        private const string ENCRYPT_TYPE = "encrypt_type";
        private const string BIZ_CONTENT = "biz_content";
        private const string APP_AUTH_TOKEN = "app_auth_token";
        private const string RETURN_URL = "return_url";

        #region AlipayClient Constructors

        public AlipayClient(
            ILogger<AlipayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<AlipayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            OptionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        public ILogger Logger { get; set; }

        public IHttpClientFactory ClientFactory { get; set; }

        public IOptionsSnapshot<AlipayOptions> OptionsSnapshotAccessor { get; set; }

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string optionsName) where T : AlipayResponse
        {
            return await ExecuteAsync(request, optionsName, null, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string optionsName, string accessToken) where T : AlipayResponse
        {
            return await ExecuteAsync(request, optionsName, accessToken, null);
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            return await PageExecuteAsync(request, null, "POST");
        }

        public async Task<T> PageExecuteAsync<T>(string optionsName, IAlipayRequest<T> request) where T : AlipayResponse
        {
            return await PageExecuteAsync(optionsName, request, null, "POST");
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string accessToken, string reqMethod) where T : AlipayResponse
        {
            return await PageExecuteAsync(null, request, accessToken, reqMethod);
        }

        public async Task<T> PageExecuteAsync<T>(string optionsName, IAlipayRequest<T> request, string accessToken, string reqMethod) where T : AlipayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { BIZ_CONTENT, Serialize(request.GetBizModel()) },
                { METHOD, request.GetApiName() },
                { VERSION, apiVersion },
                { APP_ID, options.AppId },
                { FORMAT, options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { NOTIFY_URL, request.GetNotifyUrl() },
                { CHARSET, options.Charset },
                { RETURN_URL, request.GetReturnUrl() }
            };

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(SIGN, AlipaySignature.RSASignContent(signContent, options.PrivateRSAParameters, options.SignType));

            // 是否需要上传文件
            var body = string.Empty;

            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                using (var client = ClientFactory.CreateClient())
                {
                    body = await HttpClientUtility.DoPostAsync(client, options.ServerUrl, txtParams, fileParams);
                }
            }
            else
            {
                if (reqMethod.ToUpper() == "GET")
                {
                    //拼接get请求的url
                    var tmpUrl = options.ServerUrl;
                    if (txtParams != null && txtParams.Count > 0)
                    {
                        if (tmpUrl.Contains("?"))
                        {
                            tmpUrl = tmpUrl + "&" + AlipayUtility.BuildQuery(txtParams);
                        }
                        else
                        {
                            tmpUrl = tmpUrl + "?" + AlipayUtility.BuildQuery(txtParams);
                        }
                    }
                    body = tmpUrl;
                    Logger.Log(options.LogLevel, "Request Url:{body}", body);
                }
                else
                {
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, options);
                    Logger.Log(options.LogLevel, "Request Html:{body}", body);
                }
            }

            T rsp = null;
            IAlipayParser<T> parser = null;
            if ("xml".Equals(options.Format))
            {
                parser = new AlipayXmlParser<T>();
                rsp = parser.Parse(body);
            }
            else
            {
                parser = new AlipayJsonParser<T>();
                rsp = parser.Parse(body);
            }
            return rsp;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string optionsName, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { BIZ_CONTENT, Serialize(request.GetBizModel()) },
                { METHOD, request.GetApiName() },
                { VERSION, apiVersion },
                { APP_ID, options.AppId },
                { FORMAT, options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { CHARSET, options.Charset }
            };

            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);
            }

            if (request.GetNeedEncrypt())
            {

                if (string.IsNullOrEmpty(txtParams[BIZ_CONTENT]))
                {
                    throw new Exception("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncyptKey) || string.IsNullOrEmpty(options.EncyptType))
                {
                    throw new Exception("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncyptType))
                {
                    throw new Exception("api only support Aes!");

                }

                var encryptContent = AES.Encrypt(txtParams[BIZ_CONTENT], options.EncyptKey, AlipaySignature.AES_IV, AESCipherMode.CBC, AESPaddingMode.PKCS7);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, options.EncyptType);
            }

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(SIGN, AlipaySignature.RSASignContent(signContent, options.PrivateRSAParameters, options.SignType));

            var query = AlipayUtility.BuildQuery(txtParams);
            Logger.Log(options.LogLevel, "Request:{query}", query);

            // 是否需要上传文件
            var body = string.Empty;
            using (var client = ClientFactory.CreateClient())
            {
                if (request is IAlipayUploadRequest<T> uRequest)
                {
                    var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                    body = await HttpClientUtility.DoPostAsync(client, options.ServerUrl, txtParams, fileParams);
                }
                else
                {
                    body = await HttpClientUtility.DoPostAsync(client, options.ServerUrl, query);
                }
            }

            Logger.Log(options.LogLevel, "Response:{body}", body);

            T rsp = null;
            IAlipayParser<T> parser = null;
            if ("xml".Equals(options.Format))
            {
                parser = new AlipayXmlParser<T>();
                rsp = parser.Parse(body);
            }
            else
            {
                parser = new AlipayJsonParser<T>();
                rsp = parser.Parse(body);
            }

            var item = ParseRespItem(request, body, parser, options.EncyptKey, options.EncyptType);
            rsp = parser.Parse(item.realContent);

            CheckResponseSign(request, item.respContent, rsp.IsError, parser, options.PublicRSAParameters, options.SignType);

            return rsp;
        }

        private ResponseParseItem ParseRespItem<T>(IAlipayRequest<T> request, string respBody, IAlipayParser<T> parser, string encryptKey, string encryptType) where T : AlipayResponse
        {
            string realContent = null;

            if (request.GetNeedEncrypt())
            {
                realContent = parser.EncryptSourceData(request, respBody, encryptType, encryptKey);
            }
            else
            {
                realContent = respBody;
            }

            var item = new ResponseParseItem
            {
                realContent = realContent,
                respContent = respBody
            };
            return item;

        }

        private void CheckResponseSign<T>(IAlipayRequest<T> request, string responseBody, bool isError, IAlipayParser<T> parser, RSAParameters parameters, string signType) where T : AlipayResponse
        {
            var signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            if (!isError || isError && !string.IsNullOrEmpty(signItem.Sign))
            {
                var rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, parameters, signType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, parameters, signType);
                        if (!jsonCheck)
                        {
                            throw new Exception("sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new Exception("sign check fail: check Sign and Data Fail!");
                    }
                }

            }
        }

        #endregion

        #region Common Method

        public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, AlipayOptions options)
        {
            //待请求参数数组
            var dicPara = new Dictionary<string, string>(sParaTemp);

            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + options.ServerUrl + "?charset=" + options.Charset +
                 "' method='" + strMethod + "' style='display:none;'>");

            foreach (var temp in dicPara)
            {
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            //表单实现自动提交
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");

            return sbHtml.ToString();
        }

        private AlipayDictionary BuildRequestParams<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken, AlipayOptions options) where T : AlipayResponse
        {
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();
            var result = new AlipayDictionary(request.GetParameters())
            {
                // 序列化BizModel
                { BIZ_CONTENT, Serialize(request.GetBizModel()) },
                // 添加协议级请求参数，为空的参数后面会自动过滤，这里不做处理。
                { METHOD, request.GetApiName() },
                { VERSION, apiVersion },
                { APP_ID, options.AppId },
                { FORMAT, options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { NOTIFY_URL, request.GetNotifyUrl() },
                { CHARSET, options.Charset },
                { RETURN_URL, request.GetReturnUrl() },
                { APP_AUTH_TOKEN, appAuthToken }
            };

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(result[BIZ_CONTENT]))
                {
                    throw new Exception("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncyptKey) || string.IsNullOrEmpty(options.EncyptType))
                {
                    throw new Exception("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncyptType))
                {
                    throw new Exception("api only support Aes!");
                }

                var encryptContent = AES.Encrypt(result[BIZ_CONTENT], options.EncyptKey, AlipaySignature.AES_IV, AESCipherMode.CBC, AESPaddingMode.PKCS7);
                result.Remove(BIZ_CONTENT);
                result.Add(BIZ_CONTENT, encryptContent);
                result.Add(ENCRYPT_TYPE, options.EncyptType);
            }

            return result;
        }

        #endregion

        #region SDK Execute

        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            return SdkExecuteAsync(request, null);
        }

        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, string optionsName) where T : AlipayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);

            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, null, options);

            // 字典排序
            var sortedParams = new SortedDictionary<string, string>(requestParams);
            var sortedAlipayDic = new AlipayDictionary(sortedParams);

            // 参数签名
            var signContent = AlipaySignature.GetSignContent(sortedAlipayDic);
            var signResult = AlipaySignature.RSASignContent(signContent, options.PrivateRSAParameters, options.SignType);

            // 添加签名结果参数
            sortedAlipayDic.Add(SIGN, signResult);

            // 参数拼接
            var signedResult = AlipayUtility.BuildQuery(sortedAlipayDic);

            // 构造结果
            var rsp = Activator.CreateInstance<T>();
            rsp.Body = signedResult;
            return Task.FromResult(rsp);
        }

        #endregion

        #region Model Serialize

        private static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        private string Serialize(AlipayObject bizModel)
        {
            return bizModel == null ? string.Empty : JsonConvert.SerializeObject(bizModel, jsonSerializerSettings);
        }

        public Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string optionsName) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }

        public Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string optionsName, string session, string reqMethod) where T : AlipayResponse
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
