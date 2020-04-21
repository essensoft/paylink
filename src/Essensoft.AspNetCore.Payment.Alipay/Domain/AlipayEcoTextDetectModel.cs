using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTextDetectModel Data Structure.
    /// </summary>
    public class AlipayEcoTextDetectModel : AlipayObject
    {
        /// <summary>
        /// 检测任务列表
        /// </summary>
        [JsonPropertyName("task")]
        public List<SpiDetectionTask> Task { get; set; }
    }
}
