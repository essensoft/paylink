using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 配置选项
    /// </summary>
    public class WeChatPayOptions
    {
        private string certificate;
        private string certificatePassword;

        /// <summary>
        /// 应用号
        /// 如：公众平台AppId/开放平台AppId/小程序AppId/企业微信CorpId等
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 应用密钥
        /// 如：目前仅调用"企业红包API"时，使用企业微信的AppSecret。
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 子商户应用号
        /// 仅服务商使用
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// 仅服务商使用
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// API证书(.p12)
        /// 可为 证书文件路径 / 证书文件的Base64编码
        /// </summary>
        public string Certificate
        {
            get => certificate;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    certificate = value;
                    GetCertificateInfo();
                }
            }
        }

        /// <summary>
        /// API证书密码
        /// 默认为商户号
        /// </summary>
        public string CertificatePassword
        {
            get => string.IsNullOrEmpty(certificatePassword) ? MchId : certificatePassword;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    certificatePassword = value;
                    GetCertificateInfo();
                }
            }
        }

        /// <summary>
        /// API密钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// APIv3密钥
        /// </summary>
        public string V3Key { get; set; }

        /// <summary>
        /// RSA公钥
        /// 目前仅调用"企业付款到银行卡API"时使用，执行"获取RSA加密公钥API"即可获取。
        /// </summary>
        public string RsaPublicKey { get; set; }

        internal X509Certificate2 Certificate2;
        internal RSA CertificateRSAPrivateKey;
        internal string CertificateSerialNo;

        private void GetCertificateInfo()
        {
            if (string.IsNullOrEmpty(Certificate) || string.IsNullOrEmpty(CertificatePassword))
            {
                return;
            }

            try
            {
                if (File.Exists(Certificate))
                {
                    Certificate2 = new X509Certificate2(Certificate, CertificatePassword);
                }
                else
                {
                    Certificate2 = new X509Certificate2(Convert.FromBase64String(Certificate), CertificatePassword);
                }
            }
            catch (CryptographicException ex)
            {
                throw new WeChatPayException($"反序列化证书失败，请确认是否为微信支付签发的有效PKCS#12格式证书。原始异常信息：{ex.Message}");
            }

            CertificateSerialNo = Certificate2.GetSerialNumberString();
            CertificateRSAPrivateKey = Certificate2.GetRSAPrivateKey();
        }
    }
}
