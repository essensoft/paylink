using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DateAreaModel Data Structure.
    /// </summary>
    [Serializable]
    public class DateAreaModel : AlipayObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("begin_date")]
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_date")]
        [XmlElement("end_date")]
        public string EndDate { get; set; }
    }
}
