using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptions
    {
        private string certificatePassword;

        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// QQ钱包 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// QQ钱包 API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// QQ钱包 API证书(文件名/文件的Base64编码)
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// QQ钱包 API证书密码(默认为商户号)
        /// </summary>
        public string CertificatePassword
        {
            get => string.IsNullOrEmpty(certificatePassword) ? MchId : certificatePassword;
            set => certificatePassword = value;
        }

        public string GetCertificateHash()
        {
            return MD5.Compute(Certificate);
        }
    }
}
