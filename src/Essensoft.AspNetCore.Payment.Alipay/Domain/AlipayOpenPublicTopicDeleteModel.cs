using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicTopicDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTopicDeleteModel : AlipayObject
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [JsonProperty("topic_id")]
        [XmlElement("topic_id")]
        public string TopicId { get; set; }
    }
}
