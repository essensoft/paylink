using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Image Data Structure.
    /// </summary>
    public class Image : AlipayObject
    {
        /// <summary>
        /// 图片url，请先调用alipay.offline.material.image.upload 图片上传接口获得图片url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
