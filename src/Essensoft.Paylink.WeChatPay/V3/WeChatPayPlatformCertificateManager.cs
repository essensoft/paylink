using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Essensoft.Paylink.Security;

namespace Essensoft.Paylink.WeChatPay.V3
{
    public class WeChatPayPlatformCertificateManager
    {
        private readonly ConcurrentDictionary<string, WeChatPayPlatformCertificate> _certs = new();

        /// <summary>
        /// 获取微信支付平台证书信息(指定证书序列号)。
        /// </summary>
        /// <param name="client">WeChatPay 客户端</param>
        /// <param name="options">配置选项</param>
        /// <param name="serial">证书序列号</param>
        /// <returns>微信支付平台证书信息</returns>
        public async Task<WeChatPayPlatformCertificate> GetCertificateAsync(IWeChatPayClient client, WeChatPayOptions options, string serial)
        {
            // 如果证书序列号已缓存，则直接使用缓存的证书
            if (_certs.TryGetValue(serial, out var platformCert))
            {
                return platformCert;
            }

            // 否则重新下载新的微信支付平台证书并更新缓存
            var request = new WeChatPayCertificatesRequest();
            var response = await client.ExecuteAsync(request, options);
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
                                        MchId = options.MchId,
                                        SerialNo = certificate.SerialNo,
                                        EffectiveTime = DateTime.Parse(certificate.EffectiveTime),
                                        ExpireTime = DateTime.Parse(certificate.ExpireTime),
                                        Certificate = new X509Certificate2(Encoding.ASCII.GetBytes(certStr), string.Empty, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable)
                                    };

                                    _certs.TryAdd(certificate.SerialNo, cert);
                                }
                                break;
                            default:
                                throw new WeChatPayException($"Unknown algorithm: {certificate.EncryptCertificate.Algorithm}");
                        }
                    }
                }
            }
            else
            {
                throw new WeChatPayException("Download certificates failed!");
            }

            // 重新从缓存获取证书
            if (_certs.TryGetValue(serial, out platformCert))
            {
                return platformCert;
            }
            else
            {
                throw new WeChatPayException("Certificate not found!");
            }
        }

        /// <summary>
        /// 获取微信支付平台证书信息。
        /// </summary>
        /// <param name="client">WeChatPay 客户端</param>
        /// <param name="options">配置选项</param>
        /// <returns>微信支付平台证书信息</returns>
        public async Task<WeChatPayPlatformCertificate> GetCertificateAsync(IWeChatPayClient client, WeChatPayOptions options)
        {
            // 如果证书已缓存，则直接使用缓存的证书
            var platformCert = _certs.Values.Where(cert => cert.MchId == options.MchId && cert.EffectiveTime < DateTime.Now && cert.ExpireTime > DateTime.Now).OrderByDescending(cert => cert.EffectiveTime).FirstOrDefault();
            if (platformCert != null)
            {
                return platformCert;
            }

            // 否则重新下载新的微信支付平台证书并更新缓存
            var request = new WeChatPayCertificatesRequest();
            var response = await client.ExecuteAsync(request, options);
            if (response.StatusCode == HttpStatusCode.OK)
            {
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
                                        MchId = options.MchId,
                                        SerialNo = certificate.SerialNo,
                                        EffectiveTime = DateTime.Parse(certificate.EffectiveTime),
                                        ExpireTime = DateTime.Parse(certificate.ExpireTime),
                                        Certificate = new X509Certificate2(Encoding.ASCII.GetBytes(certStr), string.Empty, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable)
                                    };

                                    _certs.TryAdd(certificate.SerialNo, cert);
                                }
                                break;
                            default:
                                throw new WeChatPayException($"Unknown algorithm: {certificate.EncryptCertificate.Algorithm}");
                        }
                    }
                }
            }
            else
            {
                throw new WeChatPayException("Download certificates failed!");
            }

            // 重新从缓存获取证书
            platformCert = _certs.Values.Where(cert => cert.MchId == options.MchId && cert.EffectiveTime < DateTime.Now && cert.ExpireTime > DateTime.Now).OrderByDescending(cert => cert.EffectiveTime).FirstOrDefault();
            if (platformCert != null)
            {
                return platformCert;
            }
            else
            {
                throw new WeChatPayException("Certificate not found!");
            }
        }

        /// <summary>
        /// 删除失效的微信支付平台证书缓存。
        /// </summary>
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
