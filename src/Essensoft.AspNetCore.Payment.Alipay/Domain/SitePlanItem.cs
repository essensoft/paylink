using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SitePlanItem Data Structure.
    /// </summary>
    public class SitePlanItem : AlipayObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
