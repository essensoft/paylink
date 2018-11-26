using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAuctionBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAuctionBalanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id，唯一业务标识
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 开户银行标识
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 核身id，用于验证是否已经核身成功
        /// </summary>
        [JsonProperty("verify_id")]
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
