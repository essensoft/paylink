using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccountFreeze Data Structure.
    /// </summary>
    [Serializable]
    public class AccountFreeze : AlipayObject
    {
        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonProperty("freeze_amount")]
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 冻结类型名称
        /// </summary>
        [JsonProperty("freeze_name")]
        [XmlElement("freeze_name")]
        public string FreezeName { get; set; }

        /// <summary>
        /// 冻结类型值
        /// </summary>
        [JsonProperty("freeze_type")]
        [XmlElement("freeze_type")]
        public string FreezeType { get; set; }
    }
}
