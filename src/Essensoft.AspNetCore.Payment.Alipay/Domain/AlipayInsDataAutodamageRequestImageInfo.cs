using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAutodamageRequestImageInfo Data Structure.
    /// </summary>
    public class AlipayInsDataAutodamageRequestImageInfo : AlipayObject
    {
        /// <summary>
        /// 图像文件名称
        /// </summary>
        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径
        /// </summary>
        [JsonProperty("image_path")]
        public string ImagePath { get; set; }
    }
}
