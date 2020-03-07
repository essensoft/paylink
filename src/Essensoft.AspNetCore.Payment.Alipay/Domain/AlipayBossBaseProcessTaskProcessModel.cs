using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessTaskProcessModel : AlipayObject
    {
        /// <summary>
        /// 更新的业务上下文。和原有业务上下文同key覆盖，新增key新增。
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// 处理幂等值，特别注意这个值的使用，不能依赖于流程中的任何值。
        /// </summary>
        [JsonPropertyName("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 处理备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前需要推进的节点
        /// </summary>
        [JsonPropertyName("node")]
        public string Node { get; set; }

        /// <summary>
        /// 操作名称
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 当前处理人域账号
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 更新的优先级。填写0则不更新，使用原值
        /// </summary>
        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 更新的子流程上下文。完全覆盖原值。若不需要覆盖，则传null
        /// </summary>
        [JsonPropertyName("sub_contexts")]
        public List<string> SubContexts { get; set; }
    }
}
