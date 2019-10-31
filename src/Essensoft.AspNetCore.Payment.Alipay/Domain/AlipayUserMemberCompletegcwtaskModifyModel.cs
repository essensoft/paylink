using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMemberCompletegcwtaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberCompletegcwtaskModifyModel : AlipayObject
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
        /// 任务完成的时间戳，通过new Date()获取任务完成的当前时间即可
        /// </summary>
        [JsonProperty("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 任务的业务类型，与任务列表的biz_type业务类型保持一致
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务类型的结果值，按约定结果返回，比如Y
        /// </summary>
        [JsonProperty("biz_value")]
        public string BizValue { get; set; }

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
