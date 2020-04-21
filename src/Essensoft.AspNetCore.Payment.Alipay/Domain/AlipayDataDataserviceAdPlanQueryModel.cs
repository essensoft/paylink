using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPlanQueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 外部唯一计划编号
        /// </summary>
        [JsonPropertyName("plan_outer_id")]
        public string PlanOuterId { get; set; }
    }
}
