using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对象
        /// </summary>
        [JsonPropertyName("data")]
        public RechargeOrderTuitionDTO Data { get; set; }
    }
}
