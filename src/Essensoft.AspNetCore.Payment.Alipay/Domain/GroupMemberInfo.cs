using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMemberInfo : AlipayObject
    {
        /// <summary>
        /// 用户在这个群里的昵称
        /// </summary>
        [JsonProperty("group_nickname")]
        [XmlElement("group_nickname")]
        public string GroupNickname { get; set; }

        /// <summary>
        /// 个人昵称
        /// </summary>
        [JsonProperty("nickname")]
        [XmlElement("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户的uid
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
