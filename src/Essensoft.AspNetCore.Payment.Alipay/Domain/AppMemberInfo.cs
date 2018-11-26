using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppMemberInfo : AlipayObject
    {
        /// <summary>
        /// 邀请时间
        /// </summary>
        [JsonProperty("gmt_invite")]
        [XmlElement("gmt_invite")]
        public string GmtInvite { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        [JsonProperty("gmt_join")]
        [XmlElement("gmt_join")]
        public string GmtJoin { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name")]
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonProperty("portrait")]
        [XmlElement("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [JsonProperty("role")]
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 成员的状态，VALID-有效，UNCONFIRMED-未确认，TIMEOUT-已经失效，REFUSED-用户拒绝
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
