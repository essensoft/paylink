using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BeaconDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("actiontype")]
        [XmlElement("actiontype")]
        public string Actiontype { get; set; }

        /// <summary>
        /// 设备是否可用
        /// </summary>
        [JsonProperty("inuse")]
        [XmlElement("inuse")]
        public bool Inuse { get; set; }

        /// <summary>
        /// 设备说明
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonProperty("sn")]
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 蓝牙设备关联的模板信息
        /// </summary>
        [JsonProperty("template")]
        [XmlElement("template")]
        public BeaconTemplate Template { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("uuid")]
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
