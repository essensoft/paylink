using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MachineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MachineInfo : AlipayObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [JsonProperty("machine_count")]
        [XmlElement("machine_count")]
        public long MachineCount { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("machine_model")]
        [XmlElement("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 设备类型，由商户定义
        /// </summary>
        [JsonProperty("machine_type")]
        [XmlElement("machine_type")]
        public string MachineType { get; set; }
    }
}
