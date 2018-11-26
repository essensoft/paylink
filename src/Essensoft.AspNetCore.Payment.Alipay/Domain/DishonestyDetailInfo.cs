using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishonestyDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DishonestyDetailInfo : AlipayObject
    {
        /// <summary>
        /// 被执行人行为具体情况
        /// </summary>
        [JsonProperty("behavior")]
        [XmlElement("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [JsonProperty("case_code")]
        [XmlElement("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [JsonProperty("enforce_court")]
        [XmlElement("enforce_court")]
        public string EnforceCourt { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("id_number")]
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        [JsonProperty("performance")]
        [XmlElement("performance")]
        public string Performance { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [JsonProperty("publish_date")]
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [JsonProperty("region")]
        [XmlElement("region")]
        public string Region { get; set; }
    }
}
