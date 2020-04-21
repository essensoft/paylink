using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherBillDetail Data Structure.
    /// </summary>
    public class VoucherBillDetail : AlipayObject
    {
        /// <summary>
        /// 券核销/退款金额(元)
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账单类型(V_USE:支付,V_REFUND:退款)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易合作伙伴ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 交易状态(I: 处理中, S: 成功)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
