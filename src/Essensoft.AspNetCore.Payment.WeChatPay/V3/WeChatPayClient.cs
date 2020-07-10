using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Extensions;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Request;

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
                throw new ArgumentNullException(nameof(options.AppId));
            }

            if (string.IsNullOrEmpty(options.MchId))
            {
                throw new ArgumentNullException(nameof(options.MchId));
            }

            if (string.IsNullOrEmpty(options.V3Key))
            {
                throw new ArgumentNullException(nameof(options.V3Key));
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
                throw new ArgumentNullException(nameof(options.MchId));
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new ArgumentNullException(nameof(options.Certificate));
            }

            if (string.IsNullOrEmpty(options.V3Key))
            {
                throw new ArgumentNullException(nameof(options.V3Key));
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
                throw new ArgumentNullException(nameof(options.MchId));
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new ArgumentNullException(nameof(options.Certificate));
            }

            var client = _httpClientFactory.CreateClient(Name);
            var (headers, body, statusCode) = await client.PostAsync(request, options);
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

            var cert = await LoadPlatformCertificateAsync(headers.Serial, options);
            var signatureSourceData = BuildSignatureSourceData(headers.Timestamp, headers.Nonce, body);

            if (!SHA256WithRSA.Verify(cert.GetRSAPublicKey(), signatureSourceData, headers.Signature))
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        private string BuildSignatureSourceData(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }

        private async Task<X509Certificate2> LoadPlatformCertificateAsync(string serial, WeChatPayOptions options)
        {
            // 如果证书序列号已缓存，则直接使用缓存的
            if (_platformCertificateManager.TryGetValue(serial, out var certificate2))
            {
                return certificate2;
            }

            // 否则重新下载新的平台证书
            var request = new WeChatPayCertificatesRequest();
            var response = await ExecuteAsync(request, options);
            foreach (var certificate in response.Certificates)
            {
                // 若证书序列号未被缓存，解密证书并加入缓存
                if (!_platformCertificateManager.ContainsKey(certificate.SerialNo))
                {
                    switch (certificate.EncryptCertificate.Algorithm)
                    {
                        case nameof(AEAD_AES_256_GCM):
                            {
                                var certStr = AEAD_AES_256_GCM.Decrypt(certificate.EncryptCertificate.Nonce, certificate.EncryptCertificate.Ciphertext, certificate.EncryptCertificate.AssociatedData, options.V3Key);
                                var cert = new X509Certificate2(Encoding.UTF8.GetBytes(certStr));
                                _platformCertificateManager.TryAdd(certificate.SerialNo, cert);
                            }
                            break;
                        default:
                            throw new WeChatPayException($"Unknown algorithm: {certificate.EncryptCertificate.Algorithm}");
                    }
                }
            }

            // 重新从缓存获取
            if (_platformCertificateManager.TryGetValue(serial, out certificate2))
            {
                return certificate2;
            }
            else
            {
                throw new WeChatPayException("Download certificates failed!");
            }
        }

        #endregion
    }
}
