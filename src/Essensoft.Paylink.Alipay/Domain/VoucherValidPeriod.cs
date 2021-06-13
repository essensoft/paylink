using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherValidPeriod Data Structure.
    /// </summary>
    public class VoucherValidPeriod : AlipayObject
    {
        /// <summary>
        /// 券有效期。  枚举值：  ABSOLUTE：绝对时间  RELATIVE：相对时间
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券可使用的开始时间。    格式为：yyyy-MM-dd HH:mm:ss    限制：  type为ABSOLUTE时该字段必填。
        /// </summary>
        [JsonPropertyName("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券生效后N天内可以使用。    可以配合wait_days_after_receive字段使用。    限制：  type为RELATIVE时必填。    valid_days_after_receive必须大于0。
        /// </summary>
        [JsonPropertyName("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 券可使用的结束时间。    格式为yyyy-MM-dd HH:mm:ss    限制：  type为ABSOLUTE必填。    券可使用的结束时间valid_end_time 必须大于 券的发放结束时间  publish_end_time
        /// </summary>
        [JsonPropertyName("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 用户领券后需要等待N天，券才可以生效。    如果该字段填入0或者不填写，则用户领券后立刻生效。    限制：  type为RELATIVE时可选。
        /// </summary>
        [JsonPropertyName("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
