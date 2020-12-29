using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstalmentPlanDetailTuitionDTO Data Structure.
    /// </summary>
    public class InstalmentPlanDetailTuitionDTO : AlipayObject
    {
        /// <summary>
        /// 完成的计划信息
        /// </summary>
        [JsonPropertyName("plan")]
        public InstalmentPlanTuitionDTO Plan { get; set; }

        /// <summary>
        /// 打款计划涉及的周期配置
        /// </summary>
        [JsonPropertyName("recharge_order")]
        public RechargeOrderTuitionDTO RechargeOrder { get; set; }
    }
}
