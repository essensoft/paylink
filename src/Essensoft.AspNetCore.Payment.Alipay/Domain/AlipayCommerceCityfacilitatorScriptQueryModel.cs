using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorScriptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorScriptQueryModel : AlipayObject
    {
        /// <summary>
        /// 卡类型，智能卡中心的内部编码规则
        /// </summary>
        [JsonProperty("card_type")]
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 脚本类型，目前支持两种  readCardType：判定卡是什么城市的交通卡  readCardInfo：读取卡中的余额等信息
        /// </summary>
        [JsonProperty("script_type")]
        [XmlElement("script_type")]
        public string ScriptType { get; set; }
    }
}
