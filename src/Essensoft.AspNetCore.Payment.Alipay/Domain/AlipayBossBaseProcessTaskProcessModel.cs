using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessTaskProcessModel : AlipayObject
    {
        /// <summary>
        /// 更新的业务上下文。和原有业务上下文同key覆盖，新增key新增。
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 处理幂等值，特别注意这个值的使用，不能依赖于流程中的任何值。
        /// </summary>
        [JsonProperty("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 处理备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前需要推进的节点
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; set; }

        /// <summary>
        /// 操作名称
        /// </summary>
        [JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 当前处理人域账号
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 更新的优先级。填写0则不更新，使用原值
        /// </summary>
        [JsonProperty("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [JsonProperty("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 更新的子流程上下文。完全覆盖原值。若不需要覆盖，则传null
        /// </summary>
        [JsonProperty("sub_contexts")]
        public List<string> SubContexts { get; set; }
    }
}
