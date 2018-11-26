using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodUserCertifyModel : AlipayObject
    {
        /// <summary>
        /// 代理人姓名
        /// </summary>
        [JsonProperty("agent_id_card_name")]
        [XmlElement("agent_id_card_name")]
        public string AgentIdCardName { get; set; }

        /// <summary>
        /// 代理人身份证号
        /// </summary>
        [JsonProperty("agent_id_card_no")]
        [XmlElement("agent_id_card_no")]
        public string AgentIdCardNo { get; set; }

        /// <summary>
        /// 代理人用户唯一标识
        /// </summary>
        [JsonProperty("agent_user_id")]
        [XmlElement("agent_user_id")]
        public string AgentUserId { get; set; }
    }
}
