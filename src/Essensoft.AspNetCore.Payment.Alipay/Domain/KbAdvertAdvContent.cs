using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvContent Data Structure.
    /// </summary>
    public class KbAdvertAdvContent : AlipayObject
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [JsonPropertyName("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }
    }
}
