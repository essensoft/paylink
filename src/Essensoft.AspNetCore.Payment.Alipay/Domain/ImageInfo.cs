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
        /// 传入图片类型，ID表示aftsId，URL表示图片url地址
        /// </summary>
        [JsonProperty("image_type")]
        public string ImageType { get; set; }
    }
}
