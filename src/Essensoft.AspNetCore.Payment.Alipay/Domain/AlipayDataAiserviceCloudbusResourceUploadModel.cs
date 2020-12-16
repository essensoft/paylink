using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceUploadModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceUploadModel : AlipayObject
    {
        /// <summary>
        /// 内容字段
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonPropertyName("res_name")]
        public string ResName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
