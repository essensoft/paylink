using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UniversalKeyword Data Structure.
    /// </summary>
    public class UniversalKeyword : AlipayObject
    {
        /// <summary>
        /// 沟通平台动态字段映射字段名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 沟通平台动态字段映射字段值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
