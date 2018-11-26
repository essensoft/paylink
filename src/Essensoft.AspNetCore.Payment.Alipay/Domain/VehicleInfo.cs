using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleInfo : AlipayObject
    {
        /// <summary>
        /// 保险公司ID
        /// </summary>
        [JsonProperty("company_id")]
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司对应的精友码（转码）
        /// </summary>
        [JsonProperty("vehicle_code")]
        [XmlElement("vehicle_code")]
        public string VehicleCode { get; set; }
    }
}
