using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskOfflinevarsQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [JsonProperty("rowkeys")]
        [XmlElement("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
