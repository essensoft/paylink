using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateCreateResponse.
    /// </summary>
    public class AlipayOpenMiniPlanOperateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建支付后推荐方案返回的方案id，后续用户可根据该方案ID对方案进行终止和调整优先级
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
