using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommonDescInfo Data Structure.
    /// </summary>
    public class CommonDescInfo : AlipayObject
    {
        /// <summary>
        /// 图片URL地址，最大不超过60K，必须使用https
        /// </summary>
        [JsonPropertyName("img")]
        public string Img { get; set; }

        /// <summary>
        /// 文本描述
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
