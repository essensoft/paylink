using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetResponse : AlipayResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [JsonPropertyName("plan_result")]
        public AdPlan PlanResult { get; set; }
    }
}
