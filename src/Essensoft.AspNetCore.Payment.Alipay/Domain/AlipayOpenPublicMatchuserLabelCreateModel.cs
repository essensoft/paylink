using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签id，调用创建标签接口会返回label_id
        /// </summary>
        [JsonProperty("label_id")]
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签值，由开发者自主指定，标签值类型要满足创建标签接口中data_type参数的限定。
        /// </summary>
        [JsonProperty("label_value")]
        [XmlElement("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [JsonProperty("matchers")]
        [XmlArray("matchers")]
        [XmlArrayItem("matcher")]
        public List<Matcher> Matchers { get; set; }
    }
}
