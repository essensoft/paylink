using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RechargeConfigTuitionDTO Data Structure.
    /// </summary>
    public class RechargeConfigTuitionDTO : AlipayObject
    {
        /// <summary>
        /// 外部传入扩展字段，系统不管控该字段内容
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 第一期打款时间
        /// </summary>
        [JsonPropertyName("first_payment_time")]
        public string FirstPaymentTime { get; set; }

        /// <summary>
        /// 每期的时间间隔，和周期类型相关。月类型情况下，数字1表示间隔一个月，依次类推
        /// </summary>
        [JsonPropertyName("interval")]
        public long Interval { get; set; }

        /// <summary>
        /// 最后一期打款时间
        /// </summary>
        [JsonPropertyName("last_payment_time")]
        public string LastPaymentTime { get; set; }

        /// <summary>
        /// DAY("天"), MONTH("月"), YEAR("年");
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 分期数
        /// </summary>
        [JsonPropertyName("periods")]
        public long Periods { get; set; }

        /// <summary>
        /// 总金额，格式为0.00
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
