using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicDefaultExtensionCreateResponse.
    /// </summary>
    public class AlipayOpenPublicDefaultExtensionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 一套扩展区的key，创建一套扩展区成功后，支付宝会将该字段返回，后续对扩展区进行删除等操作都会用到这个值。
        /// </summary>
        [JsonProperty("extension_key")]
        [XmlElement("extension_key")]
        public string ExtensionKey { get; set; }
    }
}
