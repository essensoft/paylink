using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdvertItem Data Structure.
    /// </summary>
    public class AdvertItem : AlipayObject
    {
        /// <summary>
        /// 广告图片url, 尺寸为996*240，最大不超过5M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转类型，网页:HTTP、小程序:APP，不传默认HTTP
        /// </summary>
        [JsonPropertyName("link_type")]
        public string LinkType { get; set; }

        /// <summary>
        /// 跳转链接，点击广告图片跳到的链接url
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 广告帧名称，可选
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
