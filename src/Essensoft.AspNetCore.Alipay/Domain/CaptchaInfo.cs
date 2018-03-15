using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// CaptchaInfo Data Structure.
    /// </summary>
    public class CaptchaInfo : AlipayObject
    {
        /// <summary>
        /// 图片特殊描述信息
        /// </summary>
        [JsonProperty("captcha_desc")]
        public string CaptchaDesc { get; set; }

        /// <summary>
        /// 图片内容，base64编码
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 图片类型，jpeg|bmp
        /// </summary>
        [JsonProperty("image_type")]
        public string ImageType { get; set; }
    }
}
