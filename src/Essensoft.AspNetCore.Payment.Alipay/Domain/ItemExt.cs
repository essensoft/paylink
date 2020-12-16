using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemExt Data Structure.
    /// </summary>
    public class ItemExt : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息值
        /// </summary>
        [JsonPropertyName("ext_value")]
        public string ExtValue { get; set; }
    }
}
