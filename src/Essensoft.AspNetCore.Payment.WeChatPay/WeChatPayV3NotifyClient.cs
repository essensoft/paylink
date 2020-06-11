#if NETCOREAPP3_1

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayV3NotifyClient : IWeChatPayV3NotifyClient
    {
        #region WeChatPayV3NotifyClient Constructors

        private readonly WeChatPayPlatformCertificateManager _platformCertificateManager;
        private readonly IWeChatPayV3Client _client;

        public WeChatPayV3NotifyClient(WeChatPayPlatformCertificateManager platformCertificateManager, IWeChatPayV3Client client)
        {
            _platformCertificateManager = platformCertificateManager;
            _client = client;
        }

        #endregion

        #region IWeChatPayV3NotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request, WeChatPayOptions options) where T : WeChatPayV3Notify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();

            await CheckNotifySignAsync(request, body, options);

            var ciphertextParser = new WeChatPayObjectJsonParser<WeChatPayV3NotifyCiphertext>();
            var ciphertext = ciphertextParser.Parse(body);
            switch (ciphertext.Resource.Algorithm)
            {
                case nameof(AEAD_AES_256_GCM):
                    {
                        var plaintext = AEAD_AES_256_GCM.Decrypt(ciphertext.Resource.Nonce, ciphertext.Resource.Ciphertext, ciphertext.Resource.AssociatedData, options.V3Key);
                        var parser = new WeChatPayV3NotifyJsonParser<T>();
                        var notify = parser.Parse(plaintext, request.HttpContext.Response.StatusCode); 
                        return notify;
                    }
                default:
                    throw new WeChatPayException("Unknown algorithm!");
            }
        }

        #endregion

        #region Check Notify Method

        private async Task CheckNotifySignAsync(HttpRequest request, string body, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new WeChatPayException("sign check fail: body is empty!");
            }

            request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Serial, out var serialValues);
            request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues);
            request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues);
            if (!request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Signature, out var signatureValues))
            {
                throw new WeChatPayException("sign check fail: sign is empty!");
            }

            var serial = serialValues.First();
            var timestamp = timestampValues.First();
            var nonce = nonceValues.First();
            var signature = signatureValues.First();

            var cert = await LoadPlatformCertificateAsync(serial, options);
            var signatureSourceDate = BuildSignatureSourceDate(timestamp, nonce, body);

            if (!cert.GetRSAPublicKey().Verify(signatureSourceDate, signature))
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        private string BuildSignatureSourceDate(string timestamp, string nonce, string body)
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
            var response = await _client.ExecuteAsync(request, options);
            if (response.Certificates.Count > 0 && _platformCertificateManager.TryGetValue(serial, out certificate2))
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

#endif
