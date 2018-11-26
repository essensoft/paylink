using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesOwner Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesOwner : AlipayObject
    {
        /// <summary>
        /// 创建者的昵称
        /// </summary>
        [JsonProperty("nick")]
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶空间成员所关联的第三方用户ID
        /// </summary>
        [JsonProperty("origin_user_id")]
        [XmlElement("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
