using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduOneCardDepositCardQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOneCardDepositCardQueryResult : AlipayObject
    {
        /// <summary>
        /// 校园一卡通机构代码
        /// </summary>
        [JsonProperty("agent_code")]
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 校园一卡通机构姓名
        /// </summary>
        [JsonProperty("agent_name")]
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 校园一卡通余额
        /// </summary>
        [JsonProperty("balance")]
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 校园一卡通姓名
        /// </summary>
        [JsonProperty("card_name")]
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通卡号
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 余额最后更新时间
        /// </summary>
        [JsonProperty("last_update_time")]
        [XmlElement("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 校园一卡通待领金额
        /// </summary>
        [JsonProperty("pound_amount")]
        [XmlElement("pound_amount")]
        public string PoundAmount { get; set; }
    }
}
