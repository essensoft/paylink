using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarPromoTicketPushModel : AlipayObject
    {
        /// <summary>
        /// 核销流水
        /// </summary>
        [JsonProperty("apply_no")]
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 核销状态，0：成功，1：失败
        /// </summary>
        [JsonProperty("apply_status")]
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [JsonProperty("code_no")]
        [XmlElement("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonProperty("ticket_id")]
        [XmlElement("ticket_id")]
        public string TicketId { get; set; }
    }
}
