using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpiDetectionTask Data Structure.
    /// </summary>
    public class SpiDetectionTask : AlipayObject
    {
        /// <summary>
        /// 待检测文本内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 检测任务编号
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }
    }
}
