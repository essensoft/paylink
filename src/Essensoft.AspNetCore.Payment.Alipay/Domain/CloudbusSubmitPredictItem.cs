using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusSubmitPredictItem Data Structure.
    /// </summary>
    public class CloudbusSubmitPredictItem : AlipayObject
    {
        /// <summary>
        /// 处理过程状态描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务计划
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
