using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaImg Data Structure.
    /// </summary>
    public class NewsfeedMediaImg : AlipayObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("src")]
        public string Src { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}
