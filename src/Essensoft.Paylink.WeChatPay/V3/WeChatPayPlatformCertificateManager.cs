using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.Paylink.Security;
using Essensoft.Paylink.WeChatPay.V3.Request;

namespace Essensoft.Paylink.WeChatPay.V3
{
    public class WeChatPayPlatformCertificateManager
    {
        private readonly ConcurrentDictionary<string, WeChatPayPlatformCertificate> _certs = new();

        public async Task<WeChatPayPlatformCertificate> LoadCertificateAsync(IWeChatPayClient client, WeChatPayOptions options, string serial)
        {
            // 如果证书序列号已缓存，则直接使用缓存的
            if (_certs.TryGetValue(serial, out var platformCert))
            {
                return platformCert;
            }

            // 否则重新下载新的平台证书
            var request = new WeChatPayCertificatesRequest();
            var response = await client.ExecuteAsync(request, options);
            foreach (var certificate in response.Certificates)
            {
                // 若证书序列号未被缓存，解密证书并加入缓存
                if (!_certs.ContainsKey(certificate.SerialNo))
                {
                    switch (certificate.EncryptCertificate.Algorithm)
                    {
                        case nameof(AEAD_AES_256_GCM):
                            {
                                var certStr = AEAD_AES_256_GCM.Decrypt(certificate.EncryptCertificate.Nonce, certificate.EncryptCertificate.Ciphertext, certificate.EncryptCertificate.AssociatedData, options.APIv3Key);

                                var cert = new WeChatPayPlatformCertificate
                                {
                                    SerialNo = certificate.SerialNo,
                                    EffectiveTime = DateTime.Parse(certificate.EffectiveTime),
                                    ExpireTime = DateTime.Parse(certificate.ExpireTime),
                                    Certificate = new X509Certificate2(Encoding.ASCII.GetBytes(certStr))
                                };

                                _certs.TryAdd(certificate.SerialNo, cert);
                            }
                            break;
                        default:
                            throw new WeChatPayException($"Unknown algorithm: {certificate.EncryptCertificate.Algorithm}");
                    }
                }
            }

            // 重新从缓存获取
            if (_certs.TryGetValue(serial, out platformCert))
            {
                return platformCert;
            }
            else
            {
                throw new WeChatPayException("Download certificates failed!");
            }
        }

        public async Task<WeChatPayPlatformCertificate> GetCertificateAsync(IWeChatPayClient client, WeChatPayOptions options)
        {
            // 如果证书序列号已缓存，则直接使用缓存的
            var platformCert = _certs.Values.FirstOrDefault(cert => cert.EffectiveTime < DateTime.Now && cert.ExpireTime > DateTime.Now);
            if (platformCert != null)
            {
                return platformCert;
            }

            // 否则重新下载新的平台证书
            var request = new WeChatPayCertificatesRequest();
            var response = await client.ExecuteAsync(request, options);
            foreach (var certificate in response.Certificates)
            {
                // 若证书序列号未被缓存，解密证书并加入缓存
                if (!_certs.ContainsKey(certificate.SerialNo))
                {
                    switch (certificate.EncryptCertificate.Algorithm)
                    {
                        case nameof(AEAD_AES_256_GCM):
                            {
                                var certStr = AEAD_AES_256_GCM.Decrypt(certificate.EncryptCertificate.Nonce, certificate.EncryptCertificate.Ciphertext, certificate.EncryptCertificate.AssociatedData, options.APIv3Key);

                                var cert = new WeChatPayPlatformCertificate
                                {
                                    SerialNo = certificate.SerialNo,
                                    EffectiveTime = DateTime.Parse(certificate.EffectiveTime),
                                    ExpireTime = DateTime.Parse(certificate.ExpireTime),
                                    Certificate = new X509Certificate2(Encoding.ASCII.GetBytes(certStr))
                                };

                                _certs.TryAdd(certificate.SerialNo, cert);
                            }
                            break;
                        default:
                            throw new WeChatPayException($"Unknown algorithm: {certificate.EncryptCertificate.Algorithm}");
                    }
                }
            }

            // 重新从缓存获取
            platformCert = _certs.Values.FirstOrDefault(cert => cert.EffectiveTime < DateTime.Now && cert.ExpireTime > DateTime.Now);
            if (platformCert != null)
            {
                return platformCert;
            }
            else
            {
                throw new WeChatPayException("Download certificates failed!");
            }
        }

        public void RemoveExpireCertificates()
        {
            var certs = _certs.Values.Where(cert => cert.ExpireTime < DateTime.Now).ToList();
            foreach (var cert in certs)
            {
                _certs.TryRemove(cert.SerialNo, out _);
            }
        }
    }
}
