using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionDeleteModel : AlipayObject
    {
        /// <summary>
        /// 一套扩展区的key，删除默认扩展区时传入default ，查询扩展区列表可以获得每套扩展区的key
        /// </summary>
        [JsonPropertyName("extension_key")]
        public string ExtensionKey { get; set; }
    }
}
