using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpiDetectionTask Data Structure.
    /// </summary>
    [Serializable]
    public class SpiDetectionTask : AlipayObject
    {
        /// <summary>
        /// 待检测文本内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 检测任务编号
        /// </summary>
        [JsonProperty("data_id")]
        public string DataId { get; set; }
    }
}
