using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeTradedrivePayModel Data Structure.
    /// </summary>
    public class MybankCreditGuaranteeTradedrivePayModel : AlipayObject
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 交易驱动金额，单位分
        /// </summary>
        [JsonPropertyName("order_encash_amt")]
        public string OrderEncashAmt { get; set; }

        /// <summary>
        /// 交易驱动金额对应币种
        /// </summary>
        [JsonPropertyName("order_encash_ccy")]
        public string OrderEncashCcy { get; set; }

        /// <summary>
        /// 还款业务编码。交易驱动还款时，根据AE的收款信息业务ID生成
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// AE卖家id
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
