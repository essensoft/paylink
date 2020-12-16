using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KmsBakingCheckDTO Data Structure.
    /// </summary>
    public class KmsBakingCheckDTO : AlipayObject
    {
        /// <summary>
        /// 回传结束时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 回传起始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 回传数量
        /// </summary>
        [JsonPropertyName("sync_count")]
        public string SyncCount { get; set; }

        /// <summary>
        /// 回传日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("sync_time")]
        public string SyncTime { get; set; }
    }
}
