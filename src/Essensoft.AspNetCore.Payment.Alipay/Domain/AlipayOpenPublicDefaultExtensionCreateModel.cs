using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicDefaultExtensionCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicDefaultExtensionCreateModel : AlipayObject
    {
        /// <summary>
        /// 默认扩展区列表，最多包含3个扩展区
        /// </summary>
        [JsonPropertyName("areas")]
        public List<ExtensionArea> Areas { get; set; }
    }
}
