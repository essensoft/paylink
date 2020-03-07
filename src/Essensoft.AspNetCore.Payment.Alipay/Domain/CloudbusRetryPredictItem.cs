using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusRetryPredictItem Data Structure.
    /// </summary>
    public class CloudbusRetryPredictItem : AlipayObject
    {
        /// <summary>
        /// 处理过程状态描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 重试任务计划
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
