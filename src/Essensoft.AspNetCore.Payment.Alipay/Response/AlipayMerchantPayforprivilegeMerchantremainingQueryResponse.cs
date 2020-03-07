using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMerchantremainingQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeMerchantremainingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消费者未使用的权益金部分
        /// </summary>
        [JsonPropertyName("unused_benefit")]
        public string UnusedBenefit { get; set; }

        /// <summary>
        /// 消费者尚未使用的本金部分
        /// </summary>
        [JsonPropertyName("unused_principal")]
        public string UnusedPrincipal { get; set; }

        /// <summary>
        /// 消费者已使用的权益金部分
        /// </summary>
        [JsonPropertyName("used_benefit")]
        public string UsedBenefit { get; set; }

        /// <summary>
        /// 消费者已使用的本金部分
        /// </summary>
        [JsonPropertyName("used_principal")]
        public string UsedPrincipal { get; set; }
    }
}
