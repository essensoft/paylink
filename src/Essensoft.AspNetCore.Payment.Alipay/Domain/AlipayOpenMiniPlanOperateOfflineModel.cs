using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPlanOperateOfflineModel : AlipayObject
    {
        /// <summary>
        /// 指定创建方案的 pid, 该字段仅白名单应用可用, 其他情况下会被忽略
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 已创建的支付后推荐方案id
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
    }
}
