using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointCard Data Structure.
    /// </summary>
    public class PointCard : AlipayObject
    {
        /// <summary>
        /// 工具的描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 工具的有效期的结束时间（必须晚于活动的结束时间）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 工具的LOGO文件ID
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 工具的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 工具的有效期的起始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 工具类型，目前支持：  集点卡：POINT_CARD
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
