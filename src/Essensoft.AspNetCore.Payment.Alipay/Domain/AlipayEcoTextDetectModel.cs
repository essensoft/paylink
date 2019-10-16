using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTextDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextDetectModel : AlipayObject
    {
        /// <summary>
        /// 检测任务列表
        /// </summary>
        [JsonProperty("task")]
        public List<SpiDetectionTask> Task { get; set; }
    }
}
