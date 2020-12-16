using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ObjectKeyWord Data Structure.
    /// </summary>
    public class ObjectKeyWord : AlipayObject
    {
        /// <summary>
        /// 大类
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 物体标签
        /// </summary>
        [JsonPropertyName("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
