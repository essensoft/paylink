using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("label_id")]
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [JsonProperty("matchers")]
        [XmlArray("matchers")]
        [XmlArrayItem("matcher")]
        public List<Matcher> Matchers { get; set; }
    }
}
