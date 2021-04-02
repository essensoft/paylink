using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.Paylink.Security;
using Essensoft.Paylink.WeChatPay.V3.Extensions;
using Essensoft.Paylink.WeChatPay.V3.Parser;

namespace Essensoft.Paylink.WeChatPay.V3
{
    public class WeChatPayClient : IWeChatPayClient
    {
        public const string Name = "WeChatPay.V3.Client";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly WeChatPayPlatformCertificateManager _platformCertificateManager;

        #region WeChatPayClient Constructors

        public WeChatPayClient(IHttpClientFactory httpClientFactory, WeChatPayPlatformCertificateManager platformCertificateManager)
        {
            _httpClientFactory = httpClientFactory;
            _platformCertificateManager = platformCertificateManager;
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

            if (string.IsNullOrEmpty(options.APIv3Key))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIv3Key)} is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(sortedTxtParams, options);

            return Task.FromResult(sortedTxtParams);
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayGetRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.Certificate)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.APIv3Key))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.APIv3Key)} is Empty!");
            }

            var client = _httpClientFactory.CreateClient(Name);
            var (headers, body, statusCode) = await client.GetAsync(request, options);
            var parser = new WeChatPayResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            if (request.GetNeedCheckSign())
            {
                await CheckSignAsync(headers, body, options);
            }

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayPostRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.Certificate)} is Empty!");
            }

            var client = _httpClientFactory.CreateClient(Name);
            var (headers, body, statusCode) = await client.PostAsync(request, options);
            var parser = new WeChatPayResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            await CheckSignAsync(headers, body, options);

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayPrivacyPostRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.MchId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException($"options.{nameof(WeChatPayOptions.Certificate)} is Empty!");
            }

            var cert = await _platformCertificateManager.GetCertificateAsync(this, options);

            // 加密敏感信息
            EncryptPrivacyProperty(request.GetBodyModel(), cert.Certificate.GetRSAPublicKey());

            var client = _httpClientFactory.CreateClient(Name);
            var (headers, body, statusCode) = await client.PostAsync(request, options, cert.SerialNo);
            var parser = new WeChatPayResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            await CheckSignAsync(headers, body, options);

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

#if NETCOREAPP3_1 || NET5_0
        public async Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var headers = GetWeChatPayHeadersFromRequest(request);
            using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                var body = await reader.ReadToEndAsync();
                return await ExecuteAsync<T>(headers, body, options);
            }
        }

        private static WeChatPayHeaders GetWeChatPayHeadersFromRequest(Microsoft.AspNetCore.Http.HttpRequest request)
        {
            var headers = new WeChatPayHeaders();

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Serial, out var serialValues))
            {
                headers.Serial = serialValues.First();
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues))
            {
                headers.Timestamp = timestampValues.First();
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues))
            {
                headers.Nonce = nonceValues.First();
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Signature, out var signatureValues))
            {
                headers.Signature = signatureValues.First();
            }

            return headers;
        }
#endif

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(WeChatPayHeaders headers, string body, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.APIv3Key))
            {
                throw new WeChatPayException($"options.{nameof(options.APIv3Key)} is Empty!");
            }

            await CheckSignAsync(headers, body, options);

            var parser = new WeChatPayNotifyJsonParser<T>();
            var notify = parser.Parse(body, options.APIv3Key);

            return notify;
        }

        #endregion

        #region Check Sign Method

        private async Task CheckSignAsync(WeChatPayHeaders headers, string body, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(headers.Serial))
            {
                throw new WeChatPayException($"sign check fail: {nameof(headers.Serial)} is empty!");
            }

            if (string.IsNullOrEmpty(headers.Signature))
            {
                throw new WeChatPayException($"sign check fail: {nameof(headers.Signature)} is empty!");
            }

            var cert = await _platformCertificateManager.GetCertificateAsync(this, options, headers.Serial);
            var signSourceData = WeChatPayUtility.BuildSignatureSourceData(headers.Timestamp, headers.Nonce, body);
            var signCheck = SHA256WithRSA.Verify(cert.Certificate.GetRSAPublicKey(), signSourceData, headers.Signature);
            if (!signCheck)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion

        #region Helper

        /// <summary>
        /// 加密敏感信息字段
        /// </summary>
        /// <remarks>
        /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_3.shtml">敏感信息加解密</a></para>
        /// </remarks>
        private static void EncryptPrivacyProperty(object obj, RSA rsa)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(string)) // 为string类型
                {
                    var val = prop.GetValue(obj, null); // 获取值
                    if (val is null) // 跳过空值
                    {
                        continue;
                    }

                    if (prop.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false)) // 是否标记为敏感信息
                    {
                        if (val is string str)
                        {
                            if (string.IsNullOrEmpty(str)) // 跳过空字符串
                            {
                                continue;
                            }

                            // 加密并将加密串设置回对象。
                            var encStr = OaepSHA1WithRSA.Encrypt(rsa, str);
                            prop.SetValue(obj, encStr, null);
                        }
                    }
                }
                else if (prop.PropertyType.IsClass)
                {
                    var subObj = prop.GetValue(obj, null); // 获取子对象
                    if (subObj is null) // 跳过空值
                    {
                        continue;
                    }

                    if (subObj is not WeChatPayObject) // 跳过除WeChatPayObject和基类为WeChatPayObject以外的一切类型。
                    {
                        continue;
                    }

                    EncryptPrivacyProperty(subObj, rsa); // 继续加密子对象
                }
            }
        }

        #endregion
    }
}
