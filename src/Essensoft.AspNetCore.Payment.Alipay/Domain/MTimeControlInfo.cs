using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MTimeControlInfo Data Structure.
    /// </summary>
    public class MTimeControlInfo : AlipayObject
    {
        /// <summary>
        /// 权益时间段限制周期类型，枚举值：按天：DAY、自然周：WEEK
        /// </summary>
        [JsonPropertyName("time_dimension_type")]
        public string TimeDimensionType { get; set; }

        /// <summary>
        /// 时间值，该值只有time_dimension_type=WEEK时可用，指定时间段，例如每周一、周二、周日的06:00:00到20:04:59可用，设置值为“06:00:00,20:04:59”，多个时间区间，中间用“^”隔开,最多支持5段
        /// </summary>
        [JsonPropertyName("times")]
        public string Times { get; set; }

        /// <summary>
        /// 维度所所对应的值，当time_dimension_type=WEEK时，values取值范围为1~7，分表代表周一到周日；而time_dimension_type=DAY，values取值示例为“2018-12-12,2018-12-22”，不支持"^"分隔，如需要设置多个日期时段，请设置多个时间组
        /// </summary>
        [JsonPropertyName("values")]
        public string Values { get; set; }
    }
}
