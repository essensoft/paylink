using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTemplateCreateModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务号，控制幂等
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 模板适用的商家pid列表，不传默认为商户id
        /// </summary>
        [JsonPropertyName("consume_pid_list")]
        public List<string> ConsumePidList { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [JsonPropertyName("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 扩展内容，主要满足文案和展示类、个性化定制需求
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 会员协议html文本
        /// </summary>
        [JsonPropertyName("member_agreement")]
        public string MemberAgreement { get; set; }

        /// <summary>
        /// 会员模式。 PAID_MEMBER，付费会员； PROMISE_MEMBER，承诺会员。
        /// </summary>
        [JsonPropertyName("member_mode")]
        public string MemberMode { get; set; }

        /// <summary>
        /// 会员规则
        /// </summary>
        [JsonPropertyName("member_rule")]
        public MemberRule MemberRule { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
