using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMemberTakegcwtaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberTakegcwtaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，16位2088开头。
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 应用id，固定值，用于识别相关调用方的应用来源
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 任务流水id，唯一值，用于双方幂等控制
        /// </summary>
        [JsonProperty("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
