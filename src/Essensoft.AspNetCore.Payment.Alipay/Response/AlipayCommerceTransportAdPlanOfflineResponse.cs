using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 广告计划下线结果 + 根据广告计划id操作计划下线，下线成功返回true，否则返回false
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
