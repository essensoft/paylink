using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartCityCommodityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartCityCommodityInfo : AlipayObject
    {
        /// <summary>
        /// 服务归属
        /// </summary>
        [JsonProperty("affiliation")]
        [XmlElement("affiliation")]
        public string Affiliation { get; set; }

        /// <summary>
        /// 授权文件
        /// </summary>
        [JsonProperty("auth_file")]
        [XmlElement("auth_file")]
        public string AuthFile { get; set; }

        /// <summary>
        /// 测试验收说明
        /// </summary>
        [JsonProperty("test_detail")]
        [XmlElement("test_detail")]
        public string TestDetail { get; set; }

        /// <summary>
        /// 测试报表
        /// </summary>
        [JsonProperty("test_report")]
        [XmlElement("test_report")]
        public string TestReport { get; set; }

        /// <summary>
        /// 用户指南
        /// </summary>
        [JsonProperty("user_guide")]
        [XmlElement("user_guide")]
        public string UserGuide { get; set; }
    }
}
