using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SummaryData Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryData : AlipayObject
    {
        /// <summary>
        /// 成年人客流数
        /// </summary>
        [JsonProperty("adult")]
        public long Adult { get; set; }

        /// <summary>
        /// 平均截留时间
        /// </summary>
        [JsonProperty("avg_stop_time")]
        public string AvgStopTime { get; set; }

        /// <summary>
        /// 背面截留率
        /// </summary>
        [JsonProperty("back_interception_rate")]
        public string BackInterceptionRate { get; set; }

        /// <summary>
        /// 老年人客流数
        /// </summary>
        [JsonProperty("elder")]
        public long Elder { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 正面截留率
        /// </summary>
        [JsonProperty("face_interception_rate")]
        public string FaceInterceptionRate { get; set; }

        /// <summary>
        /// 女性客流数
        /// </summary>
        [JsonProperty("female")]
        public long Female { get; set; }

        /// <summary>
        /// 男性客流数
        /// </summary>
        [JsonProperty("male")]
        public long Male { get; set; }

        /// <summary>
        /// 未成年客流数
        /// </summary>
        [JsonProperty("nonage")]
        public long Nonage { get; set; }

        /// <summary>
        /// 感知客流量
        /// </summary>
        [JsonProperty("person_view")]
        public long PersonView { get; set; }

        /// <summary>
        /// 侧面截留率
        /// </summary>
        [JsonProperty("side_interception_rate")]
        public string SideInterceptionRate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }
    }
}
