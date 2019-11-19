using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptions
    {
        internal string CertificateHash;

        private string certificate;
        private string certificatePassword;

        /// <summary>
        /// 微信应用密钥(企业微信Secret，目前仅"企业红包API"使用)
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 微信应用号(公众平台AppId/开放平台AppId/小程序AppId/企业微信CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 微信支付 子商户应用号(仅服务商时使用)
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 微信支付 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 微信支付 子商户号(仅服务商时使用)
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信支付 API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 微信支付 API证书(文件名/文件的Base64编码)
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
        /// 微信支付 API证书密码(默认为商户号)
        /// </summary>
        public string CertificatePassword
        {
            get => string.IsNullOrEmpty(certificatePassword) ? MchId : certificatePassword;
            set => certificatePassword = value;
        }

        /// <summary>
        /// 微信支付 RSA公钥(目前仅"企业付款到银行卡API"使用，调用"获取RSA加密公钥API"即可获取)
        /// </summary>
        public string RsaPublicKey { get; set; }
    }
}
