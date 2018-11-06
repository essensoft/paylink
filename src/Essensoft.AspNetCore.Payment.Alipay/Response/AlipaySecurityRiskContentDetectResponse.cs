using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskContentDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 表示处理结果，REJECTED表示拦截，PASSED表示放过。
        /// </summary>
        [JsonProperty("action")]
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 命中的关键词列表
        /// </summary>
        [JsonProperty("keywords")]
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 业务唯一识别码，可用来对应异步识别结果
        /// </summary>
        [JsonProperty("unique_id")]
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
