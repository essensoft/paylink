using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtraParams Data Structure.
    /// </summary>
    public class ExtraParams : AlipayObject
    {
        /// <summary>
        /// 轻会员场景下协议结算周期，由协议生效日期到失效日期拼接(yyyyMMddHHmmss-yyyyMMddHHmmss)，精确到秒。
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 轻会员费用结算原始信息。详细字段说明：total_real_pay_amount轻会员周期内累计支付宝支付金额， total_pay_count轻会员周期内累计支付宝支付次数，total_discount_amount轻会员周期内累计享受的轻会员优惠。（上面金额字段单位为元，精确小数点后两位）
        /// </summary>
        [JsonPropertyName("period_summary_info")]
        public string PeriodSummaryInfo { get; set; }
    }
}
