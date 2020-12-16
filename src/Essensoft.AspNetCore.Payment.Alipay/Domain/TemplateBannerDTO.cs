using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateBannerDTO Data Structure.
    /// </summary>
    public class TemplateBannerDTO : AlipayObject
    {
        /// <summary>
        /// 横幅图片ID，通过接口（alipay.offline.material.image.upload）上传图片获得图片ID。图片需在1M以内，支持bmp、png、jpeg、jpg、gif格式，建议使用710*200px的图片。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("banner_img")]
        public string BannerImg { get; set; }

        /// <summary>
        /// 横幅区域点击跳转链接，需要带上http、https、alipays等协议头。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("banner_url")]
        public string BannerUrl { get; set; }
    }
}
