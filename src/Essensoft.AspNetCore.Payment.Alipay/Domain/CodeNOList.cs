using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeNOList Data Structure.
    /// </summary>
    [Serializable]
    public class CodeNOList : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 对应TP活动码
        /// </summary>
        [JsonProperty("code_no")]
        [XmlElement("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 如果ticket_type为油券，则该字段1:石化，2:石油
        /// </summary>
        [JsonProperty("sub_type")]
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 券类型,1:油券
        /// </summary>
        [JsonProperty("ticket_type")]
        [XmlElement("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("valid_date")]
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
