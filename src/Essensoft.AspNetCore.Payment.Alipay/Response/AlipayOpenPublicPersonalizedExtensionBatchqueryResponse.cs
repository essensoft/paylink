using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展区套数
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 扩展区信息
        /// </summary>
        [JsonProperty("extensions")]
        [XmlArray("extensions")]
        [XmlArrayItem("query_extension")]
        public List<QueryExtension> Extensions { get; set; }
    }
}
