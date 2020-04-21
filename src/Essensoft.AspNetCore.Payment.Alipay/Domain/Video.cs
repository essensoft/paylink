using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    public class Video : AlipayObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将视频上传到素材中心后，生成的ID
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
