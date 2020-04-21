using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// McardTemplate Data Structure.
    /// </summary>
    public class McardTemplate : AlipayObject
    {
        /// <summary>
        /// 会员卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 会员卡模板创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 会员卡模板修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 会员卡模板展示样式，会员卡在卡包中的卡面展示效果
        /// </summary>
        [JsonPropertyName("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }
    }
}
