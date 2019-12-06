using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndexBlockBanner Data Structure.
    /// </summary>
    public class IndexBlockBanner : AlipayObject
    {
        /// <summary>
        /// 图片地址，展示需要的图片信息
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 特殊落地页,如果这里没值,会跳到栏目的二级页
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }
    }
}
