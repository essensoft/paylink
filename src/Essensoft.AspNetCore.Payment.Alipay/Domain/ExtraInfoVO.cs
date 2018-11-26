using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtraInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExtraInfoVO : AlipayObject
    {
        /// <summary>
        /// 是否是taomaomao好友关系
        /// </summary>
        [JsonProperty("maomao_friend")]
        [XmlElement("maomao_friend")]
        public bool MaomaoFriend { get; set; }

        /// <summary>
        /// 是否注册taomaomao游戏
        /// </summary>
        [JsonProperty("maomao_register")]
        [XmlElement("maomao_register")]
        public bool MaomaoRegister { get; set; }

        /// <summary>
        /// 支付宝对应的taobao_id
        /// </summary>
        [JsonProperty("taobao_id")]
        [XmlElement("taobao_id")]
        public string TaobaoId { get; set; }
    }
}
