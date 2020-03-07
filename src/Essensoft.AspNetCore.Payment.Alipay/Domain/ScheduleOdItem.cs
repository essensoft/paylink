using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleOdItem Data Structure.
    /// </summary>
    public class ScheduleOdItem : AlipayObject
    {
        /// <summary>
        /// 客流聚类结果分段（通常为1~6）
        /// </summary>
        [JsonPropertyName("cluster_class")]
        public string ClusterClass { get; set; }

        /// <summary>
        /// 线路方向枚举   0：上行  1 下行
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 日均下车人数
        /// </summary>
        [JsonPropertyName("end_load")]
        public string EndLoad { get; set; }

        /// <summary>
        /// 下车人数比例
        /// </summary>
        [JsonPropertyName("end_load_percent")]
        public string EndLoadPercent { get; set; }

        /// <summary>
        /// 下车站点名称
        /// </summary>
        [JsonPropertyName("end_name")]
        public string EndName { get; set; }

        /// <summary>
        /// 下车站点序号
        /// </summary>
        [JsonPropertyName("end_num")]
        public long EndNum { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 日均上车人数
        /// </summary>
        [JsonPropertyName("start_load")]
        public string StartLoad { get; set; }

        /// <summary>
        /// 杭州东
        /// </summary>
        [JsonPropertyName("start_name")]
        public string StartName { get; set; }

        /// <summary>
        /// 上车站点序号
        /// </summary>
        [JsonPropertyName("start_num")]
        public long StartNum { get; set; }

        /// <summary>
        /// 发车时段，若time_span为30，则06:00:00表示06:00:00-06:30:00的时段
        /// </summary>
        [JsonPropertyName("time_period")]
        public string TimePeriod { get; set; }
    }
}
