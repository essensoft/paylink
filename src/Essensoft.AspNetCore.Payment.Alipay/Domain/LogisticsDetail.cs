using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsDetail : AlipayObject
    {
        /// <summary>
        /// 物流类型,   POST 平邮,  EXPRESS 其他快递,  VIRTUAL 虚拟物品,  EMS EMS,  DIRECT 无需物流。
        /// </summary>
        [JsonProperty("logistics_type")]
        [XmlElement("logistics_type")]
        public string LogisticsType { get; set; }
    }
}
