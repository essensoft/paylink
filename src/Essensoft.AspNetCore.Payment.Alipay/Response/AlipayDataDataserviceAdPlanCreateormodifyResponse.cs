using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPlanCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 计划id
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 外部计划编号
        /// </summary>
        [JsonProperty("plan_outer_id")]
        public string PlanOuterId { get; set; }
    }
}
