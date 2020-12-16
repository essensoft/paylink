using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchFinishModel Data Structure.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchFinishModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extra_map")]
        public string ExtraMap { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 时效任务流水ID
        /// </summary>
        [JsonPropertyName("task_flow_id_list")]
        public List<string> TaskFlowIdList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
