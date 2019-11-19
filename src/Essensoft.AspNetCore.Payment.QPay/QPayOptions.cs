using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptions
    {
        internal string CertificateHash;

        private string certificate;
        private string certificatePassword;

        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// QQ钱包 子商户应用号(仅服务商时使用)
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// QQ钱包 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// QQ钱包 子商户号(仅服务商时使用)
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// QQ钱包 API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// QQ钱包 API证书(文件名/文件的Base64编码)
        /// </summary>
        public string Certificate
        {
            get => certificate;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    certificate = value;
                    CertificateHash = MD5.Compute(certificate);
                }
            }
        }

        /// <summary>
        /// QQ钱包 API证书密码(默认为商户号)
        /// </summary>
        public string CertificatePassword
        {
            get => string.IsNullOrEmpty(certificatePassword) ? MchId : certificatePassword;
            set => certificatePassword = value;
        }
    }
}
