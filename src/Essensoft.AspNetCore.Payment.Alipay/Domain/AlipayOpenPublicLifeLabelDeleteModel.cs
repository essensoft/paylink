using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id, 只支持生活号自定义标签
        /// </summary>
        [JsonProperty("label_id")]
        [XmlElement("label_id")]
        public string LabelId { get; set; }
    }
}
