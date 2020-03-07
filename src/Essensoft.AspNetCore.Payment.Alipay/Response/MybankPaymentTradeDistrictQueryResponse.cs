using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryResponse.
    /// </summary>
    public class MybankPaymentTradeDistrictQueryResponse : AlipayResponse
    {
        /// <summary>
        /// District列表
        /// </summary>
        [JsonPropertyName("district_details")]
        public List<District> DistrictDetails { get; set; }
    }
}
