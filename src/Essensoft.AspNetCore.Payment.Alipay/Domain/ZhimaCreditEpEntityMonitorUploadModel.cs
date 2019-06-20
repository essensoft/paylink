using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorUploadModel : AlipayObject
    {
        /// <summary>
        /// 监控实体列表（实体名，实体代码）
        /// </summary>
        [JsonProperty("entity_list")]
        public string EntityList { get; set; }

        /// <summary>
        /// 监控实体类别
        /// </summary>
        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 监控方案ID,可空
        /// </summary>
        [JsonProperty("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 芝麻商户2688 ID
        /// </summary>
        [JsonProperty("zhima_pid")]
        public string ZhimaPid { get; set; }
    }
}
