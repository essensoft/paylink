using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayOptions
    {
        public static readonly string DefaultClientName = "Payment.WechatPay.Client";
        public static readonly string CertificateClientName = "Payment.WechatPay.CertificateClient";

        /// <summary>
        /// 应用账号(公众账号ID/小程序ID/企业号CorpId)
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }

        private string rsaPublicKey;
        /// <summary>
        /// RSA公钥 企业付款到银行卡
        /// </summary>
        public string RsaPublicKey
        {
            get {
                return rsaPublicKey;
            }
            set {
                rsaPublicKey = value;
                PublicKey = RSAUtilities.GetPublicKeyParameterFormAsn1PublicKey(rsaPublicKey);
            }
        }

        internal AsymmetricKeyParameter PublicKey;
    }
}
