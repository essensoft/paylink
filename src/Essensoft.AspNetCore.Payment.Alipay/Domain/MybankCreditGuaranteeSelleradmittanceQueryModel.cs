using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeSelleradmittanceQueryModel Data Structure.
    /// </summary>
    public class MybankCreditGuaranteeSelleradmittanceQueryModel : AlipayObject
    {
        /// <summary>
        /// AE卖家sellerLoginID
        /// </summary>
        [JsonPropertyName("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }
    }
}
