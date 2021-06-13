using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherRefundModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherRefundModel : AlipayObject
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 当前订单的退券时间。    格式为：yyyy-MM-dd HH:mm:ss    特别说明：  支付宝的退款时间按照外部退款的时间为准。
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 当前订单的退款总金额(包含优惠券金额)，单位为元。  限制：  该笔订单的资金总额，取值范围[0.01,100000000]，精确到小数点后2位。
        /// </summary>
        [JsonPropertyName("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 已核销待退券的券码
        /// </summary>
        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
