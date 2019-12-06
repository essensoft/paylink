using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateStyleInfoDTO Data Structure.
    /// </summary>
    public class TemplateStyleInfoDTO : AlipayObject
    {
        /// <summary>
        /// 背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；  图片不得有圆角，不得拉伸变形
        /// </summary>
        [JsonPropertyName("background_id")]
        public string BackgroundId { get; set; }

        /// <summary>
        /// banner图片地址。 通过接口（alipay.offline.material.image.upload）上传图片。
        /// </summary>
        [JsonPropertyName("banner_img_id")]
        public string BannerImgId { get; set; }

        /// <summary>
        /// banner跳转地址。
        /// </summary>
        [JsonPropertyName("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// 字体颜色（非背景色），只影响卡详情中部信息区域字体颜色
        /// </summary>
        [JsonPropertyName("bg_color")]
        public string BgColor { get; set; }

        /// <summary>
        /// 品牌商名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 钱包端显示名称（字符串长度）
        /// </summary>
        [JsonPropertyName("card_show_name")]
        public string CardShowName { get; set; }

        /// <summary>
        /// 注意：此字段已废弃。  卡片颜色
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// 栏位信息布局。目前只支持list（列表）或grid（宫格）形式。如果为空则默认为list。
        /// </summary>
        [JsonPropertyName("column_info_layout")]
        public string ColumnInfoLayout { get; set; }

        /// <summary>
        /// 特色信息，用于领卡预览
        /// </summary>
        [JsonPropertyName("feature_descriptions")]
        public List<string> FeatureDescriptions { get; set; }

        /// <summary>
        /// 设置是否在卡面展示（个人头像）图片信息，默认不展示；  当前仅用于身份验证信息类型的个人头像图片；  图片id随创建卡/更新卡时传入；  详见会员卡产品文档。
        /// </summary>
        [JsonPropertyName("front_image_enable")]
        public bool FrontImageEnable { get; set; }

        /// <summary>
        /// 设置是否在卡面展示文案信息，默认不展示；  文案信息分行展示，最多展示4行文案，每行文案分为label和value两部分；  文案实际内容随创建卡/更新卡时传入；  详见会员卡产品说明文档。
        /// </summary>
        [JsonPropertyName("front_text_list_enable")]
        public bool FrontTextListEnable { get; set; }

        /// <summary>
        /// logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；  请优先使用商家LOGO；
        /// </summary>
        [JsonPropertyName("logo_id")]
        public string LogoId { get; set; }

        /// <summary>
        /// 标语
        /// </summary>
        [JsonPropertyName("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 标语图片， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [JsonPropertyName("slogan_img_id")]
        public string SloganImgId { get; set; }
    }
}
