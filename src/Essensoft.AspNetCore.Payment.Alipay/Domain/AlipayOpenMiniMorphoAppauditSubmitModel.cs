using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppauditSubmitModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoAppauditSubmitModel : AlipayObject
    {
        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 闪蝶身份验证信息
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 2张应用截图
        /// </summary>
        [JsonPropertyName("screen_shots")]
        public string ScreenShots { get; set; }
    }
}
