using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser;
using MD5 = Essensoft.AspNetCore.Payment.Security.MD5;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        #region WeChatPayNotifyClient Constructors

        private readonly WeChatPayPlatformCertificateManager _platformCertificateManager;
        private readonly IWeChatPayClient _client;

        public WeChatPayNotifyClient(WeChatPayPlatformCertificateManager platformCertificateManager, IWeChatPayClient client)
        {
            _platformCertificateManager = platformCertificateManager;
            _client = client;
        }

        #endregion

        #region V2

        #region IWeChatPayNotifyClient Members

#if NETCOREAPP3_1
        public async Task<T> ExecuteV2Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : V2.WeChatPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var body = await new StreamReader(request.Body, Encoding.UTF8).ReadToEndAsync();
            return await ExecuteV2Async<T>(body, options);
        }
#endif

        #endregion

        #region IWeChatPayNotifyClient Members

        public Task<T> ExecuteV2Async<T>(string body, WeChatPayOptions options) where T : V2.WeChatPayNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var parser = new WeChatPayNotifyXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is V2.Notify.WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.Key).ToLowerInvariant();
                var data = AES.Decrypt((notify as V2.Notify.WeChatPayRefundNotify).ReqInfo, key, CipherMode.ECB, PaddingMode.PKCS7);
                notify = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(notify, options);
            }

            return Task.FromResult(notify);
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(V2.WeChatPayNotify notify, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (notify.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (!notify.Parameters.TryGetValue("sign", out var sign))
            {
                throw new WeChatPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.Key, WeChatPaySignType.MD5);
            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion

        #endregion

        #region V3

        #region IWeChatPayNotifyClient Members

#if NETCOREAPP3_1
        public async Task<T> ExecuteV3Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : V3.WeChatPayNotify
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

            return await ExecuteV3Async<T>(body, serial, timestamp, nonce, signature, options);
        }
#endif

        #endregion

        #region IWeChatPayNotifyClient Members

        public async Task<T> ExecuteV3Async<T>(string body, string serial, string timestamp, string nonce, string signature, WeChatPayOptions options) where T : V3.WeChatPayNotify
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

            var parser = new WeChatPayNotifyJsonParser<T>();
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

            if (!SHA256WithRSA.Verify(cert.GetRSAPublicKey(), signatureSourceData, signature))
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
            var request = new V3.Request.WeChatPayCertificatesRequest();
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

        #endregion
    }
}
