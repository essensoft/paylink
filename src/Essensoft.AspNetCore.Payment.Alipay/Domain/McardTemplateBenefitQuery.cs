using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// McardTemplateBenefitQuery Data Structure.
    /// </summary>
    public class McardTemplateBenefitQuery : AlipayObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [JsonPropertyName("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 会员卡模板权益扩展信息：JSON格式; openUrl 说明：跳转到商户的优惠活动页面
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 权益标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
