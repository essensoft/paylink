using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPrizesendAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolPrizesendAuthModel : AlipayObject
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        [JsonProperty("prize_id")]
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 外部流水号，保证业务幂等性
        /// </summary>
        [JsonProperty("req_id")]
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 发奖用户ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
