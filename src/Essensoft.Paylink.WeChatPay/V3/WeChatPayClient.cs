using System;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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
                await CheckResponseSignAsync(headers, body, options);
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

            await CheckResponseSignAsync(headers, body, options);

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

            await CheckResponseSignAsync(headers, body, options);

            return response;
        }

        #endregion

        #region Check Response Method

        private async Task CheckResponseSignAsync(WeChatPayHeaders headers, string body, WeChatPayOptions options)
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
        private static void EncryptPrivacyProperty(WeChatPayObject obj, RSA rsa)
        {
            foreach (var propertyInfo in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (propertyInfo.PropertyType == typeof(string)) // 为string类型
                {
                    if (propertyInfo.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false)) // 是否标记为敏感信息
                    {
                        var value = propertyInfo.GetValue(obj, null); // 获取值
                        if (value is string strValue)
                        {
                            if (string.IsNullOrEmpty(strValue))
                            {
                                continue; // 跳过空字符串
                            }

                            // 加密并将加密串设置回对象
                            var strEncrypted = OaepSHA1WithRSA.Encrypt(rsa, strValue);
                            propertyInfo.SetValue(obj, strEncrypted, null);
                        }
                    }
                }
                else if (propertyInfo.PropertyType.IsClass)
                {
                    var value = propertyInfo.GetValue(obj, null); // 获取子对象
                    if (value is null)
                    {
                        continue; // 跳过空值
                    }

                    if (value is WeChatPayObject weChatPayObject)
                    {
                        EncryptPrivacyProperty(weChatPayObject, rsa); // 继续加密
                    }
                    else
                    {
                        continue; // 跳过其他类型
                    }
                }
            }
        }

        #endregion
    }
}
