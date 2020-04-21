using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NextUrl Data Structure.
    /// </summary>
    public class NextUrl : AlipayObject
    {
        /// <summary>
        /// 小宝账户详情页跳转链接
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转链接的展示文案
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
