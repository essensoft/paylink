using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentPassword Data Structure.
    /// </summary>
    public class KbAdvertContentPassword : AlipayObject
    {
        /// <summary>
        /// 红包口令
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// 红包口令分享地址
        /// </summary>
        [JsonPropertyName("share_page_url")]
        public string SharePageUrl { get; set; }
    }
}
