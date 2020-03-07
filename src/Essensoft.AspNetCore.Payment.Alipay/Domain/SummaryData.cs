using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SummaryData Data Structure.
    /// </summary>
    public class SummaryData : AlipayObject
    {
        /// <summary>
        /// 成年人客流数
        /// </summary>
        [JsonPropertyName("adult")]
        public long Adult { get; set; }

        /// <summary>
        /// 平均截留时间
        /// </summary>
        [JsonPropertyName("avg_stop_time")]
        public string AvgStopTime { get; set; }

        /// <summary>
        /// 背面截留率
        /// </summary>
        [JsonPropertyName("back_interception_rate")]
        public string BackInterceptionRate { get; set; }

        /// <summary>
        /// 老年人客流数
        /// </summary>
        [JsonPropertyName("elder")]
        public long Elder { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 正面截留率
        /// </summary>
        [JsonPropertyName("face_interception_rate")]
        public string FaceInterceptionRate { get; set; }

        /// <summary>
        /// 女性客流数
        /// </summary>
        [JsonPropertyName("female")]
        public long Female { get; set; }

        /// <summary>
        /// 男性客流数
        /// </summary>
        [JsonPropertyName("male")]
        public long Male { get; set; }

        /// <summary>
        /// 未成年客流数
        /// </summary>
        [JsonPropertyName("nonage")]
        public long Nonage { get; set; }

        /// <summary>
        /// 感知客流量
        /// </summary>
        [JsonPropertyName("person_view")]
        public long PersonView { get; set; }

        /// <summary>
        /// 侧面截留率
        /// </summary>
        [JsonPropertyName("side_interception_rate")]
        public string SideInterceptionRate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }
    }
}
