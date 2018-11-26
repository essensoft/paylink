using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicContactFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicContactFollowListResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [JsonProperty("contact_follow_list")]
        [XmlArray("contact_follow_list")]
        [XmlArrayItem("string")]
        public List<string> ContactFollowList { get; set; }
    }
}
