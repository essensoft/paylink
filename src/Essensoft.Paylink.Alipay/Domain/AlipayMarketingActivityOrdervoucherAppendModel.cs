using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherAppendModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherAppendModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券总预算值。  限制： 券总预算<= 999999  特别说明： 该字段的含义是追加到的数量。 不可减少，只能增加。  code_mode= MERCHANT_UPLOAD的情况下， voucher_quantity需要与导入码的总数量保持一致。
        /// </summary>
        [JsonPropertyName("voucher_quantity")]
        public long VoucherQuantity { get; set; }
    }
}
