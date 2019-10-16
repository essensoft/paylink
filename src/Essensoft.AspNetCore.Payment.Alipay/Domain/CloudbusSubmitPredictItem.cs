using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusSubmitPredictItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusSubmitPredictItem : AlipayObject
    {
        /// <summary>
        /// 处理过程状态描述
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务计划
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
    }
}
