using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAmlriskQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAmlriskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 事件ID，由入参得来
        /// </summary>
        [JsonProperty("event_id")]
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 根据反洗钱风险检查，该商户是否有风险，有风险则为Yes，无风险则为No
        /// </summary>
        [JsonProperty("has_risk")]
        [XmlElement("has_risk")]
        public string HasRisk { get; set; }

        /// <summary>
        /// 商户ID，由入参得来
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 当发现有风险时，以列表形式表示风险详情，风险点可以有0个至多个。
        /// </summary>
        [JsonProperty("risks")]
        [XmlArray("risks")]
        [XmlArrayItem("merchant_screen_hit")]
        public List<MerchantScreenHit> Risks { get; set; }
    }
}
