using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorUploadModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorUploadModel : AlipayObject
    {
        /// <summary>
        /// 监控实体列表（实体名，实体代码）
        /// </summary>
        [JsonPropertyName("entity_list")]
        public string EntityList { get; set; }

        /// <summary>
        /// 监控实体类别
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 监控方案ID,可空
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 芝麻商户2688 ID
        /// </summary>
        [JsonPropertyName("zhima_pid")]
        public string ZhimaPid { get; set; }
    }
}
