using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Extensions;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    public class WeChatPayClient : IWeChatPayClient
    {
        public const string Name = "WeChatPay.V3.WeChatPayClient";

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
                throw new WeChatPayException("options.AppId is Empty!");
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new WeChatPayException("options.MchId is Empty!");
            }

            if (string.IsNullOrEmpty(options.V3Key))
            {
                throw new WeChatPayException("options.V3Key is Empty!");
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, sortedTxtParams);

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
                throw new WeChatPayException("options.MchId is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException("options.Certificate is Empty!");
            }

            if (string.IsNullOrEmpty(options.V3Key))
            {
                throw new WeChatPayException("options.V3Key is Empty!");
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
                throw new WeChatPayException("options.MchId is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException("options.Certificate is Empty!");
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
                throw new WeChatPayException("options.MchId is Empty!");
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new WeChatPayException("options.Certificate is Empty!");
            }

            var cert = await _platformCertificateManager.GetCertificateAsync(this, options);

            EncryptRequestPrivacyProperty(cert.Certificate.GetRSAPublicKey(), request.GetBodyModel());

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

            var cert = await _platformCertificateManager.LoadCertificateAsync(this, options, headers.Serial);
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
        /// 加密标记敏感信息的属性
        /// </summary>
        private static void EncryptRequestPrivacyProperty(RSA rsa, object obj)
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

                    EncryptRequestPrivacyProperty(rsa, subObj); // 继续加密子对象
                }
            }
        }

        #endregion
    }
}
