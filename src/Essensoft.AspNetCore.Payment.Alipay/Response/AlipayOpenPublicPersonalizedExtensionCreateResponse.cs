using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展区套id，创建个性化扩展区成功后，支付宝会将该字段返回，后续扩展区上下线或者扩展区删除都会用到这个值。
        /// </summary>
        [JsonProperty("extension_key")]
        [XmlElement("extension_key")]
        public string ExtensionKey { get; set; }
    }
}
