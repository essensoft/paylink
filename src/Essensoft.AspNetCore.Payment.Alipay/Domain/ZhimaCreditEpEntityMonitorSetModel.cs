using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorSetModel : AlipayObject
    {
        /// <summary>
        /// 联系人列表
        /// </summary>
        [JsonProperty("contact_list")]
        [XmlElement("contact_list")]
        public string ContactList { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [JsonProperty("solution_id")]
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
