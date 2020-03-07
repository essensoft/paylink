using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMemberremainingQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeMemberremainingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余额中未使用的权益金部分
        /// </summary>
        [JsonPropertyName("unused_benefit")]
        public string UnusedBenefit { get; set; }

        /// <summary>
        /// 余额中未使用的本金部分
        /// </summary>
        [JsonPropertyName("unused_principal")]
        public string UnusedPrincipal { get; set; }
    }
}
