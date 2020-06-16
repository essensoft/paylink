using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;

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

#if NETCOREAPP3_1
        public async Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayV3Notify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();

            var serial = string.Empty;
            var timestamp = string.Empty;
            var nonce = string.Empty;
            var signature = string.Empty;

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Serial, out var serialValues) && serialValues.Count() == 1)
            {
                serial = serialValues.ElementAt(0);
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues) && timestampValues.Count() == 1)
            {
                timestamp = timestampValues.ElementAt(0);
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues) && nonceValues.Count() == 1)
            {
                nonce = nonceValues.ElementAt(0);
            }

            if (request.Headers.TryGetValue(WeChatPayConsts.Wechatpay_Signature, out var signatureValues) && signatureValues.Count() == 1)
            {
                signature = signatureValues.ElementAt(0);
            }

            return await ExecuteAsync<T>(body, serial, timestamp, nonce, signature, options);
        }
#endif

        #endregion

        #region IWeChatPayV3NotifyClient Members

        public async Task<T> ExecuteAsync<T>(string body, string serial, string timestamp, string nonce, string signature, WeChatPayOptions options) where T : WeChatPayV3Notify
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.V3Key))
            {
                throw new ArgumentNullException(nameof(options.V3Key));
            }

            await CheckNotifySignAsync(body, serial, timestamp, nonce, signature, options);

            var parser = new WeChatPayV3NotifyJsonParser<T>();
            var notify = parser.Parse(body, options.V3Key);

            return notify;
        }

        #endregion

        #region Check Notify Method

        private async Task CheckNotifySignAsync(string body, string serial, string timestamp, string nonce, string signature, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new WeChatPayException("sign check fail: body is empty!");
            }

            if (string.IsNullOrEmpty(serial))
            {
                throw new WeChatPayException($"sign check fail: {nameof(serial)} is empty!");
            }

            if (string.IsNullOrEmpty(signature))
            {
                throw new WeChatPayException($"sign check fail: {nameof(signature)} is empty!");
            }

            var cert = await LoadPlatformCertificateAsync(serial, options);
            var signatureSourceData = BuildSignatureSourceData(timestamp, nonce, body);

            if (!cert.GetRSAPublicKey().Verify(signatureSourceData, signature))
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
