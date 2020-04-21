using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantConfigRequest Data Structure.
    /// </summary>
    public class MerchantConfigRequest : AlipayObject
    {
        /// <summary>
        /// 详情页banner跳转目标小程序appid
        /// </summary>
        [JsonPropertyName("banner_app_id")]
        public string BannerAppId { get; set; }

        /// <summary>
        /// 详情页banner图片url
        /// </summary>
        [JsonPropertyName("banner_image_url")]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// 详情页banner跳转所需参数
        /// </summary>
        [JsonPropertyName("banner_page")]
        public string BannerPage { get; set; }

        /// <summary>
        /// 详情页banner跳转地址
        /// </summary>
        [JsonPropertyName("banner_web_url")]
        public string BannerWebUrl { get; set; }

        /// <summary>
        /// 目标小程序appid
        /// </summary>
        [JsonPropertyName("jump_app_id")]
        public string JumpAppId { get; set; }

        /// <summary>
        /// 跳转所需参数
        /// </summary>
        [JsonPropertyName("jump_page")]
        public string JumpPage { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [JsonPropertyName("jump_web_url")]
        public string JumpWebUrl { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [JsonPropertyName("merchant_contact")]
        public string MerchantContact { get; set; }

        /// <summary>
        /// 签署平台为商家分配的应用Id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家logo
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }
    }
}
