using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 选项。
    /// </summary>
    public class LianLianPayOptions
    {
        internal ICipherParameters PrivateKey;
        internal ICipherParameters PublicKey;

        private string rsaPrivateKey;
        private string rsaPublicKey;

        /// <summary>
        /// 连连支付公钥
        /// </summary>
        public string RsaPublicKey
        {
            get => rsaPublicKey;
            set
            {
                rsaPublicKey = value;
                if (!string.IsNullOrEmpty(rsaPublicKey))
                {
                    PublicKey = RSAUtilities.GetKeyParameterFormPublicKey(rsaPublicKey);
                }
            }
        }

        /// <summary>
        /// 商户私钥
        /// </summary>
        public string RsaPrivateKey
        {
            get => rsaPrivateKey;
            set
            {
                rsaPrivateKey = value;
                if (!string.IsNullOrEmpty(rsaPrivateKey))
                {
                    PrivateKey = RSAUtilities.GetKeyParameterFormPrivateKey(rsaPrivateKey);
                }
            }
        }

        /// <summary>
        /// 商户号
        /// </summary>
        public string OidPartner { get; set; }

        /// <summary>
        /// 业务类型
        /// 连连支付根据商户业务为商户开设的业务类型； （101001：虚拟商品销售、109001：实物商品销售、108001：外部账户充值）
        /// </summary>
        public string BusiPartner { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        public string SignType { get; } = "RSA";
    }
}
