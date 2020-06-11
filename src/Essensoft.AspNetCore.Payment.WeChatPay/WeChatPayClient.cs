using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayClient : IWeChatPayClient
    {
        public const string Prefix = nameof(WeChatPayClient) + ".";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly WeChatPayClientCertificateManager _clientCertificateManager;
        private readonly WeChatPayPlatformCertificateManager _platformCertificateManager;

        #region WeChatPayClient Constructors

        public WeChatPayClient(IHttpClientFactory httpClientFactory, WeChatPayClientCertificateManager clientCertificateManager, WeChatPayPlatformCertificateManager platformCertificateManager)
        {
            _httpClientFactory = httpClientFactory;
            _clientCertificateManager = clientCertificateManager;
            _platformCertificateManager = platformCertificateManager;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
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

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var signType = request.GetSignType();
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, signType, sortedTxtParams);

            var client = _httpClientFactory.CreateClient(nameof(WeChatPayClient));
            var body = await client.PostAsync(request, sortedTxtParams);
            var parser = new WeChatPayResponseXmlParser<T>();
            var response = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                CheckResponseSign(response, options, signType);
            }

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public Task<T> PageExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
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

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var signType = request.GetSignType();
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, signType, sortedTxtParams);

            var url = request.GetRequestUrl();
            if (url.Contains("?"))
            {
                url += "&" + WeChatPayUtility.BuildQuery(sortedTxtParams);
            }
            else
            {
                url += "?" + WeChatPayUtility.BuildQuery(sortedTxtParams);
            }

            var rsp = Activator.CreateInstance<T>();
            rsp.Body = url;
            return Task.FromResult(rsp);
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayCertRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
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

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            if (string.IsNullOrEmpty(options.Certificate))
            {
                throw new ArgumentNullException(nameof(options.Certificate));
            }

            var signType = request.GetSignType();
            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, signType, sortedTxtParams);

            if (!_clientCertificateManager.ContainsKey(options.CertificateSerialNo))
            {
                _clientCertificateManager.TryAdd(options.CertificateSerialNo, options.X509Certificate2);
            }

            var client = _httpClientFactory.CreateClient(Prefix + options.CertificateSerialNo);
            var body = await client.PostAsync(request, sortedTxtParams);
            var parser = new WeChatPayResponseXmlParser<T>();
            var response = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                CheckResponseSign(response, options, signType);
            }

            return response;
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

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var sortedTxtParams = new WeChatPayDictionary(request.GetParameters());

            request.PrimaryHandler(options, sortedTxtParams);

            return Task.FromResult(sortedTxtParams);
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayV3GetRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response
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

            var client = _httpClientFactory.CreateClient(nameof(WeChatPayClient));
            var (serial, timestamp, nonce, signature, body, statusCode) = await client.GetAsync(request, options);
            var parser = new WeChatPayV3ResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            // 为下载微信支付平台证书证书响应时，
            if (response is WeChatPayCertificatesResponse resp)
            {
                foreach (var certificate in resp.Certificates)
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
                                throw new WeChatPayException("Unknown algorithm!");
                        }
                    }
                }
            }

            await CheckV3ResponseSignAsync(options, serial, timestamp, nonce, signature, body);

            return response;
        }

        #endregion

        #region IWeChatPayClient Members

        public async Task<T> ExecuteAsync<T>(IWeChatPayV3PostRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response
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

            var client = _httpClientFactory.CreateClient(nameof(WeChatPayClient));
            var (serial, timestamp, nonce, signature, body, statusCode) = await client.PostAsync(request, options);
            var parser = new WeChatPayV3ResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);

            await CheckV3ResponseSignAsync(options, serial, timestamp, nonce, signature, body);

            return response;
        }

        #endregion

        #region Check Response Method

        private void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options, WeChatPaySignType signType)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (response.Parameters["return_code"] == WeChatPayCode.Success)
            {
                if (!response.Parameters.TryGetValue(WeChatPayConsts.sign, out var sign))
                {
                    throw new WeChatPayException("sign check fail: sign is Empty!");
                }

                var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, options.Key, signType);
                if (cal_sign != sign)
                {
                    throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
                }
            }
        }

        private async Task CheckV3ResponseSignAsync(WeChatPayOptions options, string serial, string timestamp, string nonce, string signature, string body)
        {
            if (string.IsNullOrEmpty(serial))
            {
                throw new WeChatPayException($"sign check fail: {nameof(serial)} is empty!");
            }

            if (string.IsNullOrEmpty(signature))
            {
                throw new WeChatPayException($"sign check fail: {nameof(signature)} is empty!");
            }

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
            var response = await ExecuteAsync(request, options);
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
