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
        public const string Name = "WeChatPayClient-V3";

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
                await CheckV3ResponseSignAsync(headers, body, options);
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

            await CheckV3ResponseSignAsync(headers, body, options);

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

            EncryptPrivacyProperty(cert.Certificate.GetRSAPublicKey(), request.GetBodyModel());

            var client = _httpClientFactory.CreateClient(Name);
            var (headers, body, statusCode) = await client.PostAsync(request, options, cert.SerialNo);
            var parser = new WeChatPayResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            await CheckV3ResponseSignAsync(headers, body, options);

            return response;
        }

        #endregion

        #region Check Response Method

        private async Task CheckV3ResponseSignAsync(WeChatPayHeaders headers, string body, WeChatPayOptions options)
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
            var signatureSourceData = WeChatPayUtility.BuildSignatureSourceData(headers.Timestamp, headers.Nonce, body);

            if (!SHA256WithRSA.Verify(cert.Certificate.GetRSAPublicKey(), signatureSourceData, headers.Signature))
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion

        #region Helper

        private static void EncryptPrivacyProperty(RSA rsa, WeChatPayObject model)
        {
            var props0 = model.GetType().GetProperties();
            foreach (var prop0 in props0)
            {
                if (prop0.PropertyType.IsValueType) // 跳过值类型
                {
                    continue;
                }

                if (prop0.PropertyType == typeof(string)) // 为 string 类型
                {
                    if (prop0.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false))
                    {
                        var obj0 = prop0.GetValue(model, null);
                        if (obj0 is string str && !string.IsNullOrEmpty(str))
                        {
                            var encStr = OaepSHA1WithRSA.Encrypt(rsa, str);
                            prop0.SetValue(model, encStr, null);
                        }
                    }
                }
                else if (prop0.PropertyType.IsClass)
                {
                    var obj0 = prop0.GetValue(model, null);
                    if (obj0 is null) // 跳过空值
                    {
                        continue;
                    }

                    var props1 = prop0.PropertyType.GetProperties();
                    foreach (var prop1 in props1)
                    {
                        if (prop1.PropertyType.IsValueType) // 跳过值类型
                        {
                            continue;
                        }

                        if (prop1.PropertyType == typeof(string)) // 为 string 类型
                        {
                            if (prop1.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false))
                            {
                                var obj1 = prop1.GetValue(obj0, null);
                                if (obj1 is string str && !string.IsNullOrEmpty(str))
                                {
                                    var encStr = OaepSHA1WithRSA.Encrypt(rsa, str);
                                    prop1.SetValue(obj0, encStr, null);
                                }
                            }
                        }
                        else if (prop1.PropertyType.IsClass)
                        {
                            var obj1 = prop1.GetValue(obj0, null);
                            if (obj1 is null) // 跳过空值
                            {
                                continue;
                            }

                            var props2 = prop1.PropertyType.GetProperties();
                            foreach (var prop2 in props2)
                            {
                                if (prop2.PropertyType.IsValueType) // 跳过值类型
                                {
                                    continue;
                                }

                                if (prop2.PropertyType == typeof(string)) // 为 string 类型
                                {
                                    if (prop2.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false))
                                    {
                                        var obj2 = prop2.GetValue(obj1, null);
                                        if (obj2 is string str && !string.IsNullOrEmpty(str))
                                        {
                                            var encStr = OaepSHA1WithRSA.Encrypt(rsa, str);
                                            prop2.SetValue(obj1, encStr, null);
                                        }
                                    }
                                }
                                else if (prop2.PropertyType.IsClass)
                                {
                                    var obj2 = prop2.GetValue(obj1, null);
                                    if (obj2 is null) // 跳过空值
                                    {
                                        continue;
                                    }

                                    var props3 = prop2.PropertyType.GetProperties();
                                    foreach (var prop3 in props3)
                                    {
                                        if (prop3.PropertyType.IsValueType) // 跳过值类型
                                        {
                                            continue;
                                        }

                                        if (prop3.PropertyType == typeof(string)) // 为 string 类型
                                        {
                                            if (prop3.IsDefined(typeof(WeChatPayPrivacyPropertyAttribute), false))
                                            {
                                                var obj3 = prop3.GetValue(obj2, null);
                                                if (obj3 is string str && !string.IsNullOrEmpty(str))
                                                {
                                                    var encStr = OaepSHA1WithRSA.Encrypt(rsa, str);
                                                    prop3.SetValue(obj2, encStr, null);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
