using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGnoticeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGnoticeModifyModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [JsonProperty("group_notice")]
        [XmlElement("group_notice")]
        public string GroupNotice { get; set; }
    }
}
