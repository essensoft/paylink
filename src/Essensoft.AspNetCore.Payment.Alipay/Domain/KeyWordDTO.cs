using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KeyWordDTO Data Structure.
    /// </summary>
    public class KeyWordDTO : AlipayObject
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

        /// <summary>
        /// 置信度打分
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
