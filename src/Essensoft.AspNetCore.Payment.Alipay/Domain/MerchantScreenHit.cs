using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantScreenHit Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantScreenHit : AlipayObject
    {
        /// <summary>
        /// 送检的实体类型，如CEO，控股人，等
        /// </summary>
        [JsonProperty("input_type")]
        [XmlElement("input_type")]
        public string InputType { get; set; }

        /// <summary>
        /// 命中详情
        /// </summary>
        [JsonProperty("risk_detail")]
        [XmlElement("risk_detail")]
        public string RiskDetail { get; set; }
    }
}
