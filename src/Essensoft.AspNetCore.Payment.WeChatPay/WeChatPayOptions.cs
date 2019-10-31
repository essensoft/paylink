using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptions
    {
        private string certificatePassword;

        /// <summary>
        /// 微信应用账号(公众平台AppId/开放平台AppId/小程序AppId/企业微信CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 微信应用密钥(企业微信Secret，目前仅"企业红包API"使用)
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 微信支付 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 微信支付 API秘钥
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 微信支付 API证书(文件名/文件的Base64编码)
        /// </summary>
        public string Certificate { get; set; }

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

        public string GetCertificateHash()
        {
            return MD5.Compute(Certificate);
        }
    }
}
