namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayOptions
    {
        public static readonly string DefaultClientName = "Payment.LianLianPay.Client";

        /// <summary>
        /// 连连支付公钥
        /// </summary>
        public string RsaPublicKey { get; set; }

        /// <summary>
        /// 商户私钥
        /// </summary>
        public string RsaPrivateKey { get; set; }

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
