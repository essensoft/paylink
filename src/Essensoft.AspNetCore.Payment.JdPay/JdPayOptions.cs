namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayOptions
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string Merchant { get; set; }

        /// <summary>
        /// 京东DES秘钥
        /// </summary>
        public string DesKey { get; set; }

        /// <summary>
        /// 京东RSA公钥
        /// </summary>
        public string RsaPublicKey { get; set; }

        /// <summary>
        /// 商户RSA私钥
        /// </summary>
        public string RsaPrivateKey { get; set; }
    }
}
