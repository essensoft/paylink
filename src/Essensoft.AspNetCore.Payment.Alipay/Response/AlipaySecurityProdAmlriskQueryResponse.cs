using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 根据反洗钱风险检查，该商户是否有风险，有风险则为Yes，无风险则为No
        /// </summary>
        [JsonPropertyName("has_risk")]
        public string HasRisk { get; set; }

        /// <summary>
        /// 商户ID，由入参得来
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 当发现有风险时，以列表形式表示风险详情，风险点可以有0个至多个。
        /// </summary>
        [JsonPropertyName("risks")]
        public List<MerchantScreenHit> Risks { get; set; }
    }
}
