using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ImageInfo : AlipayObject
    {
        /// <summary>
        /// 图片aftsId或者url
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// 传入图片类型
        /// </summary>
        [JsonProperty("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 图片数据md5值
        /// </summary>
        [JsonProperty("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 图片数据标识名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
