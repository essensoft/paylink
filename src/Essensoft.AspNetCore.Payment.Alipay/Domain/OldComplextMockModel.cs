using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OldComplextMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class OldComplextMockModel : AlipayObject
    {
        /// <summary>
        /// biz_num
        /// </summary>
        [JsonProperty("biz_num")]
        [XmlElement("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// biz_type
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 简单model
        /// </summary>
        [JsonProperty("simple_mock_model")]
        [XmlElement("simple_mock_model")]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
