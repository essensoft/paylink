using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingIotMerchantplanCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 操作类型：CREATE（新增） / MODIFY（修改）
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商家活动ID，当修改报名详情时，本参数需要有值
        /// </summary>
        [JsonPropertyName("merchant_plan_id")]
        public string MerchantPlanId { get; set; }

        /// <summary>
        /// 商家小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家小程序页面地址
        /// </summary>
        [JsonPropertyName("mini_app_page")]
        public string MiniAppPage { get; set; }

        /// <summary>
        /// IoT展位投放计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 投放资源内容，如优惠券ID
        /// </summary>
        [JsonPropertyName("resource_content")]
        public string ResourceContent { get; set; }

        /// <summary>
        /// 投放资源类型，如：IOT_MERCHANT_VOUCHER（商家自发券）
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// IoT展位码
        /// </summary>
        [JsonPropertyName("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
