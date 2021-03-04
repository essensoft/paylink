using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
