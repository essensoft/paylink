using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantActivityModifyVoucherInfo Data Structure.
    /// </summary>
    public class MerchantActivityModifyVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 券logo  券logo最大字符数不能超过64
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 使用须知  券使用须知最大字符数不能超过256
        /// </summary>
        [JsonPropertyName("user_introductions")]
        public string UserIntroductions { get; set; }

        /// <summary>
        /// 领取后, 第几天失效  valid_time_type=RELATIVE时有效且必填  只允许增加领取后可用天数
        /// </summary>
        [JsonPropertyName("valid_days_range_to")]
        public long ValidDaysRangeTo { get; set; }

        /// <summary>
        /// 有效期截止时间  valid_time_type=FIXED时有效且必填  券有效结束时间格式必须为yyyy-MM-dd HH:mm:ss  只允许延长固定时间的结束时间（支持到分）
        /// </summary>
        [JsonPropertyName("valid_time_range_to")]
        public string ValidTimeRangeTo { get; set; }

        /// <summary>
        /// 有效期类型：  枚举值：RELATIVE/FIXED
        /// </summary>
        [JsonPropertyName("valid_time_type")]
        public string ValidTimeType { get; set; }
    }
}
