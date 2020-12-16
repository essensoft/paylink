using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAbntaskModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceAbntaskModifyModel : AlipayObject
    {
        /// <summary>
        /// 操作任务列表
        /// </summary>
        [JsonPropertyName("operate_task_list")]
        public List<OperateTask> OperateTaskList { get; set; }

        /// <summary>
        /// 操作时间，yyyy-MM-dd HH:mm:ss格式的字符串，不传的话默认为当前时间
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作人id，操作人在开发者系统中的账号id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人昵称
        /// </summary>
        [JsonPropertyName("operator_nick")]
        public string OperatorNick { get; set; }
    }
}
