using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RubbishDTO Data Structure.
    /// </summary>
    public class RubbishDTO : AlipayObject
    {
        /// <summary>
        /// 垃圾类别
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 垃圾名称
        /// </summary>
        [JsonPropertyName("key_word")]
        public string KeyWord { get; set; }
    }
}
