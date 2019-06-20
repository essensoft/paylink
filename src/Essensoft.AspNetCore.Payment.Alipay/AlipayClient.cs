using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay.Parser;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 客户端。
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

        private readonly IHttpClientFactory _httpClientFactory;

        #region AlipayClient Constructors

        public AlipayClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await PageExecuteAsync(request, options, null, "POST");
        }

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string reqMethod) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new ArgumentNullException(nameof(options.AppId));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new ArgumentNullException(nameof(options.SignType));
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new ArgumentNullException(nameof(options.AppPrivateKey));
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new ArgumentNullException(nameof(options.ServerUrl));
            }

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
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

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            string body;

            // 是否需要上传文件
            if (request is IAlipayUploadRequest<T> uploadRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uploadRequest.GetFileParameters());

                var client = _httpClientFactory.CreateClient(nameof(AlipayClient));
                body = await client.PostAsync(options.ServerUrl, txtParams, fileParams);
            }
            else
            {
                if (reqMethod.ToUpperInvariant() == "GET")
                {
                    var url = options.ServerUrl;
                    if (txtParams != null && txtParams.Count > 0)
                    {
                        if (url.Contains("?"))
                        {
                            url += "&" + AlipayUtility.BuildQuery(txtParams);
                        }
                        else
                        {
                            url += "?" + AlipayUtility.BuildQuery(txtParams);
                        }
                    }
                    body = url;
                }
                else
                {
                    body = BuildHtmlRequest(txtParams, options.ServerUrl, options.Charset, reqMethod);
                }
            }

            var parser = new AlipayJsonParser<T>();
            var rsp = parser.Parse(body);

            return rsp;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await ExecuteAsync(request, options, null, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse
        {
            return await ExecuteAsync(request, options, accessToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new ArgumentNullException(nameof(options.AppId));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new ArgumentNullException(nameof(options.SignType));
            }

            if (string.IsNullOrEmpty(options.AlipayPublicKey))
            {
                throw new ArgumentNullException(nameof(options.AlipayPublicKey));
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new ArgumentNullException(nameof(options.AppPrivateKey));
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new ArgumentNullException(nameof(options.ServerUrl));
            }

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
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

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

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
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncyptKey) || string.IsNullOrEmpty(options.EncyptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncyptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipaySignature.AESEncrypt(txtParams[BIZ_CONTENT], options.EncyptKey);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, options.EncyptType);
            }

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            string body;
            var client = _httpClientFactory.CreateClient(nameof(AlipayClient));

            // 是否需要上传文件
            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                body = await client.PostAsync(options.ServerUrl, txtParams, fileParams);
            }
            else
            {
                body = await client.PostAsync(options.ServerUrl, txtParams);
            }

            var parser = new AlipayJsonParser<T>();
            var item = ParseRespItem(request, body, parser, options.EncyptKey, options.EncyptType);
            var rsp = parser.Parse(item.RealContent);

            CheckResponseSign(request, item.RespContent, rsp.IsError, parser, options);

            return rsp;
        }

        private ResponseParseItem ParseRespItem<T>(IAlipayRequest<T> request, string respBody, IAlipayParser<T> parser, string encryptKey, string encryptType) where T : AlipayResponse
        {
            string realContent;
            if (request.GetNeedEncrypt())
            {
                realContent = parser.EncryptSourceData(request, respBody, encryptType, encryptKey);
            }
            else
            {
                realContent = respBody;
            }

            return new ResponseParseItem
            {
                RealContent = realContent,
                RespContent = respBody
            };
        }

        private void CheckResponseSign<T>(IAlipayRequest<T> request, string responseBody, bool isError, IAlipayParser<T> parser, AlipayOptions options) where T : AlipayResponse
        {
            var signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new AlipayException("sign check fail: Body is Empty!");
            }

            if (!isError || isError && !string.IsNullOrEmpty(signItem.Sign))
            {
                var rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, options.AlipayPublicKey, options.SignType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, options.AlipayPublicKey, options.SignType);
                        if (!jsonCheck)
                        {
                            throw new AlipayException("sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AlipayException("sign check fail: check Sign and Data Fail!");
                    }
                }
            }
        }

        #endregion

        #region Common Method

        private string BuildHtmlRequest(IDictionary<string, string> dictionary, string serverUrl, string charset, string strMethod)
        {
            var sb = new StringBuilder();
            sb.Append($"<form id='submit' name='submit' action='{serverUrl}?charset={charset}' method='{strMethod}' style='display:none;'>");
            foreach (var iter in dictionary)
            {
                sb.Append("<input  name='" + iter.Key + "' value='" + iter.Value + "'/>");
            }
            sb.Append("<input type='submit' style='display:none;'></form>");
            sb.Append("<script>document.forms['submit'].submit();</script>");
            return sb.ToString();
        }

        private AlipayDictionary BuildRequestParams<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken, AlipayOptions options) where T : AlipayResponse
        {
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var result = new AlipayDictionary(request.GetParameters())
            {
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

            // 序列化BizModel
            result = SerializeBizModel(result, request);

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(result[BIZ_CONTENT]))
                {
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncyptKey) || string.IsNullOrEmpty(options.EncyptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncyptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipaySignature.AESEncrypt(result[BIZ_CONTENT], options.EncyptKey);
                result.Remove(BIZ_CONTENT);
                result.Add(BIZ_CONTENT, encryptContent);
                result.Add(ENCRYPT_TYPE, options.EncyptType);
            }

            return result;
        }

        #endregion

        #region SDK Execute

        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new ArgumentNullException(nameof(options.AppId));
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new ArgumentNullException(nameof(options.SignType));
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new ArgumentNullException(nameof(options.AppPrivateKey));
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new ArgumentNullException(nameof(options.ServerUrl));
            }

            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, null, options);

            // 字典排序
            var sortedParams = new SortedDictionary<string, string>(requestParams);
            var sortedDic = new AlipayDictionary(sortedParams);

            // 参数签名
            var signContent = AlipaySignature.GetSignContent(sortedDic);
            var signResult = AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType);

            // 添加签名结果参数
            sortedDic.Add(SIGN, signResult);

            // 参数拼接
            var signedResult = AlipayUtility.BuildQuery(sortedDic);

            // 构造结果
            var rsp = Activator.CreateInstance<T>();
            rsp.ResponseBody = signedResult;
            return Task.FromResult(rsp);
        }

        #endregion

        #region Model Serialize

        private static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        private AlipayDictionary SerializeBizModel<T>(AlipayDictionary requestParams, IAlipayRequest<T> request) where T : AlipayResponse
        {
            var result = requestParams;
            var isBizContentEmpty = !requestParams.ContainsKey(BIZ_CONTENT) || string.IsNullOrEmpty(requestParams[BIZ_CONTENT]);
            var bizModel = request.GetBizModel();
            if (isBizContentEmpty && bizModel != null)
            {
                var content = JsonConvert.SerializeObject(bizModel, jsonSerializerSettings);
                result.Add(BIZ_CONTENT, content);
            }

            return result;
        }

        #endregion
    }
}