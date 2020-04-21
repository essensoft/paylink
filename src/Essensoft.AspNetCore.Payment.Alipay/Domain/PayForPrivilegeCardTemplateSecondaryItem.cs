using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateSecondaryItem Data Structure.
    /// </summary>
    public class PayForPrivilegeCardTemplateSecondaryItem : AlipayObject
    {
        /// <summary>
        /// 唯一表示该区域的key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 二级区块标题
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 二级区块值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
