using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateOfflineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPlanOperateOfflineModel : AlipayObject
    {
        /// <summary>
        /// 指定创建方案的 pid, 该字段仅白名单应用可用, 其他情况下会被忽略
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 已创建的支付后推荐方案id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
