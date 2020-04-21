using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
