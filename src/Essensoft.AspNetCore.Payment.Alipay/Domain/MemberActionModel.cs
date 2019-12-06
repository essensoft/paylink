using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberActionModel Data Structure.
    /// </summary>
    public class MemberActionModel : AlipayObject
    {
        /// <summary>
        /// 行动点业务CODE，商户自定义
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行动点展示文案
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 行动点跳转链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
