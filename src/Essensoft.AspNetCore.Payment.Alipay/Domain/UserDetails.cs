using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserDetails Data Structure.
    /// </summary>
    [Serializable]
    public class UserDetails : AlipayObject
    {
        /// <summary>
        /// 用户变更手机号，替换旧的手机号
        /// </summary>
        [JsonProperty("user_change_mobile")]
        [XmlElement("user_change_mobile")]
        public string UserChangeMobile { get; set; }

        /// <summary>
        /// 孩子家长的手机号
        /// </summary>
        [JsonProperty("user_mobile")]
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [JsonProperty("user_name")]
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 孩子与家长的关系： 1、爸爸  2、妈妈  3、爷爷  4、奶奶  5、外公  6、外婆  7、家长
        /// </summary>
        [JsonProperty("user_relation")]
        [XmlElement("user_relation")]
        public string UserRelation { get; set; }
    }
}
