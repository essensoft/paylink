using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SupportFunction Data Structure.
    /// </summary>
    [Serializable]
    public class SupportFunction : AlipayObject
    {
        /// <summary>
        /// 卡名称
        /// </summary>
        [JsonProperty("card_name")]
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡类型编码，为智能卡系统的内部编码规则
        /// </summary>
        [JsonProperty("card_type")]
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 功能，支持开卡(issue)，圈存(load)，充值转账(recharge)
        /// </summary>
        [JsonProperty("function_type")]
        [XmlArray("function_type")]
        [XmlArrayItem("string")]
        public List<string> FunctionType { get; set; }

        /// <summary>
        /// 智能卡的跳转地址
        /// </summary>
        [JsonProperty("goto_url")]
        [XmlElement("goto_url")]
        public string GotoUrl { get; set; }
    }
}
