using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoTokenCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoTokenCreateModel : AlipayObject
    {
        /// <summary>
        /// 闪蝶站点 ID
        /// </summary>
        [JsonPropertyName("aid")]
        public string Aid { get; set; }

        /// <summary>
        /// 闪蝶侧用户身份唯一标识
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 闪蝶空间ID
        /// </summary>
        [JsonPropertyName("sid")]
        public string Sid { get; set; }
    }
}
