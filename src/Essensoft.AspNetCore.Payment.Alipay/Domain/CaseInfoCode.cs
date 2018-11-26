using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CaseInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class CaseInfoCode : AlipayObject
    {
        /// <summary>
        /// 情报代码，具体见《案件情报类型代码V1》
        /// </summary>
        [JsonProperty("info_code")]
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 情报描述信息
        /// </summary>
        [JsonProperty("info_code_desc")]
        [XmlElement("info_code_desc")]
        public string InfoCodeDesc { get; set; }
    }
}
