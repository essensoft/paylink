using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StressRequestItem Data Structure.
    /// </summary>
    public class StressRequestItem : AlipayObject
    {
        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源大小，单位是B
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 请求时间，单位是 ms
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
