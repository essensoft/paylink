using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BusinessHoursInfo Data Structure.
    /// </summary>
    public class BusinessHoursInfo : AlipayObject
    {
        /// <summary>
        /// 营业日：周一、周二、周三、周四、周五、周六、周日
        /// </summary>
        [JsonPropertyName("business_date")]
        public List<string> BusinessDate { get; set; }

        /// <summary>
        /// 结束营业时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 其他描述
        /// </summary>
        [JsonPropertyName("extra_desc")]
        public string ExtraDesc { get; set; }

        /// <summary>
        /// 开始营业时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
