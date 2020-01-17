using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoUser Data Structure.
    /// </summary>
    public class MorphoUser : AlipayObject
    {
        /// <summary>
        /// 闪蝶侧用户ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户花名
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }
    }
}
