using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoIdentity Data Structure.
    /// </summary>
    public class MorphoIdentity : AlipayObject
    {
        /// <summary>
        /// 闪蝶侧用户身份唯一标识
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }
    }
}
