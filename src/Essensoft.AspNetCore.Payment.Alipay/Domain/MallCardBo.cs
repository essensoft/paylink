using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallCardBo Data Structure.
    /// </summary>
    public class MallCardBo : AlipayObject
    {
        /// <summary>
        /// 商圈会员卡权益描述
        /// </summary>
        [JsonPropertyName("benefit_desc")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 会员卡图片url
        /// </summary>
        [JsonPropertyName("card_logo_url")]
        public string CardLogoUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 等级展示名称
        /// </summary>
        [JsonPropertyName("level_show_name")]
        public string LevelShowName { get; set; }

        /// <summary>
        /// 会员卡卡模版ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 权益标题 多个权益用,分隔
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
