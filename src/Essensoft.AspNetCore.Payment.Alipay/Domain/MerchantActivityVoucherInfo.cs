using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantActivityVoucherInfo Data Structure.
    /// </summary>
    public class MerchantActivityVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 券logo  券logo最大字符数不能超过64
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 子标题  券子标题最大字符数不能超过256  券子标题最小字符数不能低于2
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 使用须知  券使用须知最大字符数不能超过1000
        /// </summary>
        [JsonPropertyName("user_introductions")]
        public string UserIntroductions { get; set; }

        /// <summary>
        /// 领取后, 第几天开始生效  valid_time_type=RELATIVE时有效且必填
        /// </summary>
        [JsonPropertyName("valid_days_range_from")]
        public long ValidDaysRangeFrom { get; set; }

        /// <summary>
        /// 领取后, 第几天失效  valid_time_type=RELATIVE时有效且必填
        /// </summary>
        [JsonPropertyName("valid_days_range_to")]
        public long ValidDaysRangeTo { get; set; }

        /// <summary>
        /// 有效期开始时间  valid_time_type=FIXED时有效且必填  券有效开始时间格式必须为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("valid_time_range_from")]
        public string ValidTimeRangeFrom { get; set; }

        /// <summary>
        /// 有效期截止时间  valid_time_type=FIXED时有效且必填  券有效结束时间格式必须为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("valid_time_range_to")]
        public string ValidTimeRangeTo { get; set; }

        /// <summary>
        /// 有效期类型
        /// </summary>
        [JsonPropertyName("valid_time_type")]
        public string ValidTimeType { get; set; }
    }
}
