using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ImageInfo Data Structure.
    /// </summary>
    public class ImageInfo : AlipayObject
    {
        /// <summary>
        /// 图片aftsId或者url
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 传入图片类型
        /// </summary>
        [JsonPropertyName("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 图片数据md5值
        /// </summary>
        [JsonPropertyName("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 图片数据标识名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
