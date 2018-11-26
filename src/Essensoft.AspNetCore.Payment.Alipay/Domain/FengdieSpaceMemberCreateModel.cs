using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceMemberCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSpaceMemberCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户的昵称
        /// </summary>
        [JsonProperty("nick")]
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶业务空间成员所关联的第三方用户 ID
        /// </summary>
        [JsonProperty("origin_user_id")]
        [XmlElement("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
