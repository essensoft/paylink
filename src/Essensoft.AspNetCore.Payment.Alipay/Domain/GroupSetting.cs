using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupSetting Data Structure.
    /// </summary>
    [Serializable]
    public class GroupSetting : AlipayObject
    {
        /// <summary>
        /// 群名称
        /// </summary>
        [JsonProperty("group_name")]
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否开放群成员邀请
        /// </summary>
        [JsonProperty("is_openinv")]
        [XmlElement("is_openinv")]
        public bool IsOpeninv { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [JsonProperty("public_notice")]
        [XmlElement("public_notice")]
        public string PublicNotice { get; set; }
    }
}
