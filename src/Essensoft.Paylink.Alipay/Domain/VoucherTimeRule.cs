using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherTimeRule Data Structure.
    /// </summary>
    public class VoucherTimeRule : AlipayObject
    {
        /// <summary>
        /// 天数： 如果time_type=DAY，则格式为表示具体日期yyyy-MM-dd且逗号分隔的字符串；如果time_type=WEEK，则格式为表示星期几的1-7的数字且逗号分隔的字符串
        /// </summary>
        [JsonPropertyName("days")]
        public string Days { get; set; }

        /// <summary>
        /// 结束时间：格式为HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间：格式为HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 时间类型： 天（DAY）， 周（WEEK）
        /// </summary>
        [JsonPropertyName("time_type")]
        public string TimeType { get; set; }
    }
}
