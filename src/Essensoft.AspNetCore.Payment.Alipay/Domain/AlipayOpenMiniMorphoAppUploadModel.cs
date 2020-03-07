using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoAppUploadModel : AlipayObject
    {
        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 闪蝶身份校验信息
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 基于源码创建场景下的源码信息
        /// </summary>
        [JsonPropertyName("source")]
        public MorphoSource Source { get; set; }
    }
}
