using System.Text.Json.Serialization;

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
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 外部计划编号。同入参的同名字段。
        /// </summary>
        [JsonPropertyName("plan_outer_id")]
        public string PlanOuterId { get; set; }
    }
}
