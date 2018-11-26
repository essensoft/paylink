using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPersonalizedExtensionDeleteModel : AlipayObject
    {
        /// <summary>
        /// 一套扩展区的key，删除默认扩展区时传入default ，查询扩展区列表可以获得每套扩展区的key
        /// </summary>
        [JsonProperty("extension_key")]
        [XmlElement("extension_key")]
        public string ExtensionKey { get; set; }
    }
}
