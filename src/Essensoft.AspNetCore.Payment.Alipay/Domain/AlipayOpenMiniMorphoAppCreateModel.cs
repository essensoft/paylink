using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoAppCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoAppCreateModel : AlipayObject
    {
        /// <summary>
        /// 闪蝶创建应用的应用信息
        /// </summary>
        [JsonPropertyName("application")]
        public MorphoCreateApp Application { get; set; }

        /// <summary>
        /// 闪蝶身份校验信息
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 闪蝶创建应用的源码信息
        /// </summary>
        [JsonPropertyName("source")]
        public MorphoCreateSource Source { get; set; }

        /// <summary>
        /// 创建应用使用的模板的信息
        /// </summary>
        [JsonPropertyName("template")]
        public MorphoTemplate Template { get; set; }
    }
}
