using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduCampusJobCancelModel : AlipayObject
    {
        /// <summary>
        /// 职位来源方编码
        /// </summary>
        [JsonProperty("source_code")]
        [XmlElement("source_code")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 职位在合作方的ID
        /// </summary>
        [JsonProperty("source_id")]
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
