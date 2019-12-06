using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// McardTemplateBenefit Data Structure.
    /// </summary>
    public class McardTemplateBenefit : AlipayObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [JsonPropertyName("benefit_desc")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间。  注：在权益开始时间和结束时间范围内的权益才会认为是有效权益进行展示。
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
