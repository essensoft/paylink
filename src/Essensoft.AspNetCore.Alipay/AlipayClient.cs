using Essensoft.AspNetCore.Alipay.Parser;
using Essensoft.AspNetCore.Alipay.Request;
using Essensoft.AspNetCore.Alipay.Utility;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Alipay
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

        public AlipayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        #region AlipayClient Constructors

        public AlipayClient(IOptions<AlipayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new AlipayOptions();
            Client = new HttpClientEx();
        }

        public AlipayClient(string serverUrl, string appId, string privateKey)
            : this(null)
        {
            Options.AppId = appId;
            Options.RsaPrivateKey = privateKey;
            Options.ServerUrl = serverUrl;
        }

        public AlipayClient(string serverUrl, string appId, string privateKey, string format)
            : this(serverUrl, appId, privateKey)
        {
            Options.Format = format;
        }

        public AlipayClient(string serverUrl, string appId, string privateKey, string format, string version, string signType)
            : this(serverUrl, appId, privateKey, format)
        {
            Options.Version = version;
            Options.SignType = signType;
        }

        public AlipayClient(string serverUrl, string appId, string privateKey, string format, string version, string signType, string alipayPulicKey)
            : this(serverUrl, appId, privateKey, format, version, signType)
        {
            Options.RsaPublicKey = alipayPulicKey;
        }

        public AlipayClient(string serverUrl, string appId, string privateKey, string format, string version, string signType, string alipayPulicKey, string encyptKey)
            : this(serverUrl, appId, privateKey, format, version, signType, alipayPulicKey)
        {
            Options.EncyptKey = encyptKey;
            Options.EncyptType = "AES";
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

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            return await PageExecuteAsync<T>(request, null, "POST");
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string accessToken, string reqMethod) where T : AlipayResponse
        {
            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Options.Version;
            }

            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                // 序列化BizModel
                { BIZ_CONTENT, JsonConvert.SerializeObject(request.GetBizModel(), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) },
                // 添加协议级请求参数
                { METHOD, request.GetApiName() },
                { VERSION, apiVersion },
                { APP_ID, Options.AppId },
                { FORMAT, Options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, Options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { NOTIFY_URL, request.GetNotifyUrl() },
                { CHARSET, Options.Charset },
                { RETURN_URL, request.GetReturnUrl() }
            };

            // 添加签名参数
            txtParams.Add(SIGN, AlipaySignature.RSASign(txtParams, Options.RsaPrivateKey, Options.SignType));

            // 是否需要上传文件
            string body;

            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());
                body = await Client.DoPostAsync(Options.ServerUrl, txtParams, fileParams);
            }
            else
            {

                if (reqMethod.Equals("GET"))
                {
                    //拼接get请求的url
                    var tmpUrl = Options.ServerUrl;
                    if (txtParams != null && txtParams.Count > 0)
                    {
                        if (tmpUrl.Contains("?"))
                        {
                            tmpUrl = tmpUrl + "&" + HttpClientEx.BuildQuery(txtParams);
                        }
                        else
                        {
                            tmpUrl = tmpUrl + "?" + HttpClientEx.BuildQuery(txtParams);
                        }
                    }
                    body = tmpUrl;
                }
                else
                {
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, reqMethod);
                }
            }

            T rsp = null;
            IAlipayParser<T> parser = null;
            if ("json".Equals(Options.Format))
            {
                parser = new AlipayJsonParser<T>();
                rsp = parser.Parse(body);
            }
            return rsp;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Options.Version;
            }

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { BIZ_CONTENT, JsonConvert.SerializeObject(request.GetBizModel(), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) },
                { METHOD, request.GetApiName() },
                { VERSION, apiVersion },
                { APP_ID, Options.AppId },
                { FORMAT, Options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, Options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { CHARSET, Options.Charset }
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
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(Options.EncyptKey) || string.IsNullOrEmpty(Options.EncyptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(Options.EncyptType))
                {
                    throw new AlipayException("api only support Aes!");

                }

                var encryptContent = AlipayUtility.AesEncrypt(Options.EncyptKey, txtParams[BIZ_CONTENT]);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, Options.EncyptType);
            }

            // 添加签名参数
            txtParams.Add(SIGN, AlipaySignature.RSASign(txtParams, Options.RsaPrivateKey, Options.SignType));

            // 是否需要上传文件
            string body;
            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());
                body = await Client.DoPostAsync(Options.ServerUrl, txtParams, fileParams);
            }
            else
            {
                body = await Client.DoPostAsync(Options.ServerUrl, txtParams);
            }

            T rsp = null;
            IAlipayParser<T> parser = null;
            if ("json".Equals(Options.Format))
            {
                parser = new AlipayJsonParser<T>();
            }

            var item = ParseRespItem(request, body, parser, Options.EncyptKey, Options.EncyptType);

            rsp = parser.Parse(item.realContent);

            CheckResponseSign(request, item.respContent, rsp.IsError, parser, Options.RsaPublicKey, Options.SignType);

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

            var item = new ResponseParseItem()
            {
                realContent = realContent,
                respContent = respBody
            };
            return item;

        }

        private void CheckResponseSign<T>(IAlipayRequest<T> request, string responseBody, bool isError, IAlipayParser<T> parser, string alipayPublicKey, string signType) where T : AlipayResponse
        {
            var signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new AlipayException("sign check fail: Body is Empty!");
            }

            if (!isError || (isError && !string.IsNullOrEmpty(signItem.Sign)))
            {
                var rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, signType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, signType);
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

        #region IAlipayClient Members
        public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
        {
            //待请求参数数组
            var dicPara = new Dictionary<string, string>(sParaTemp);

            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + Options.ServerUrl + "?charset=" + Options.Charset +
                 "' method='" + strMethod + "' style='display:none;'>");

            foreach (var temp in dicPara)
            {
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
            //表单实现自动提交
            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }
        #endregion

        #region SDK Execute

        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse
        {
            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, null);

            // 字典排序
            var sortedParams = new SortedDictionary<string, string>(requestParams);
            var sortedAlipayDic = new AlipayDictionary(sortedParams);

            // 参数签名
            var signResult = AlipaySignature.RSASign(sortedAlipayDic, Options.RsaPrivateKey, Options.SignType);

            // 添加签名结果参数
            sortedAlipayDic.Add(SIGN, signResult);

            // 参数拼接
            var signedResult = HttpClientEx.BuildQuery(sortedAlipayDic);

            // 构造结果
            var rsp = (T)Activator.CreateInstance(typeof(T));
            rsp.Body = signedResult;
            return Task.FromResult(rsp);
        }

        #endregion

        #region Common Method

        private AlipayDictionary BuildRequestParams<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            // 默认参数
            var result = new AlipayDictionary(request.GetParameters())
            {
                // 序列化BizModel
                { BIZ_CONTENT, JsonConvert.SerializeObject(request.GetBizModel(), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }) },
                // 添加协议级请求参数，为空的参数后面会自动过滤，这里不做处理。
                { METHOD, request.GetApiName() },
                // 获取参数
                { VERSION, string.IsNullOrEmpty(request.GetApiVersion()) ? Options.Version : request.GetApiVersion() },
                { APP_ID, Options.AppId },
                { FORMAT, Options.Format },
                { TIMESTAMP, DateTime.Now },
                { ACCESS_TOKEN, accessToken },
                { SIGN_TYPE, Options.SignType },
                { TERMINAL_TYPE, request.GetTerminalType() },
                { TERMINAL_INFO, request.GetTerminalInfo() },
                { PROD_CODE, request.GetProdCode() },
                { NOTIFY_URL, request.GetNotifyUrl() },
                { CHARSET, Options.Charset },
                { RETURN_URL, request.GetReturnUrl() },
                { APP_AUTH_TOKEN, appAuthToken }
            };

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(result[BIZ_CONTENT]))
                {
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(Options.EncyptKey) || string.IsNullOrEmpty(Options.EncyptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(Options.EncyptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipayUtility.AesEncrypt(Options.EncyptKey, result[BIZ_CONTENT]);
                result.Remove(BIZ_CONTENT);
                result.Add(BIZ_CONTENT, encryptContent);
                result.Add(ENCRYPT_TYPE, Options.EncyptType);
            }

            return result;
        }

        #endregion
    }
}
