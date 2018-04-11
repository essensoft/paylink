using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCreditCard Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCreditCard : AlipayObject
    {
        /// <summary>
        /// 信用卡卡号，显示前6后2
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 开户行代码
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
