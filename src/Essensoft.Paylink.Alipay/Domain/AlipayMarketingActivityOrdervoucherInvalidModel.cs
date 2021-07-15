using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherInvalidModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherInvalidModel : AlipayObject
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 优惠券失效时间  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 待失效的券码 限制: 券码必须未核销且未失效
        /// </summary>
        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
