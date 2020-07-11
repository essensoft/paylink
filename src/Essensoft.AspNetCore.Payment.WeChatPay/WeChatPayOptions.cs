using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 配置选项
    /// </summary>
    public class WeChatPayOptions
    {
        internal X509Certificate2 Certificate2;
        internal RSA CertificateRSAPrivateKey;
        internal string CertificateSerialNo;

        private string certificate;
        private string certificatePassword;

        /// <summary>
        /// 应用密钥
        /// 如：目前仅调用"企业红包API"时，使用企业微信的AppSecret。
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 应用号
        /// 如：公众平台AppId/开放平台AppId/小程序AppId/企业微信CorpId等
        /// </summary>
        public string AppId { get; set; }

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
        /// API证书密码
        /// 默认为商户号
        /// </summary>
        public string CertificatePassword
        {
            get => string.IsNullOrEmpty(certificatePassword) ? MchId : certificatePassword;
            set => certificatePassword = value;
        }

        /// <summary>
        /// API证书(.p12)
        /// 证书文件路径/证书文件的base64字符串
        /// </summary>
        public string Certificate
        {
            get => certificate;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    certificate = value;

                    Certificate2 = File.Exists(certificate) ? new X509Certificate2(certificate, CertificatePassword)
                        : Base64Util.IsBase64String(certificate) ? new X509Certificate2(Convert.FromBase64String(certificate), CertificatePassword)
                        : throw new WeChatPayException("证书文件不存在或证书的Base64String不正确！");

                    CertificateSerialNo = Certificate2.GetSerialNumberString();
                    CertificateRSAPrivateKey = Certificate2.GetRSAPrivateKey();
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
    }
}
