using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ChargeInstMode Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeInstMode : AlipayObject
    {
        /// <summary>
        /// 机构简称(英文名称)
        /// </summary>
        [JsonProperty("charge_inst")]
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 机构中文名称
        /// </summary>
        [JsonProperty("charge_inst_name")]
        [XmlElement("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
