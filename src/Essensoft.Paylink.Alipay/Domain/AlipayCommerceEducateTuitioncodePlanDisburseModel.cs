using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlanDisburseModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePlanDisburseModel : AlipayObject
    {
        /// <summary>
        /// ISV订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 学费码打款计划编号
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 2088401023137175
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单支付人支付宝用户编号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
