using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionSetModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionSetModel : AlipayObject
    {
        /// <summary>
        /// 扩展区套id，调用创建个性化扩展区接口时返回
        /// </summary>
        [JsonPropertyName("extension_key")]
        public string ExtensionKey { get; set; }

        /// <summary>
        /// 扩展区操作类型，支持2个值：ON、OFF，ON代表上线操作，OFF代表下线操作。当上线一个扩展区时，若存在同样的标签规则，且状态为上线的扩展区，该扩展区会自动下线
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
