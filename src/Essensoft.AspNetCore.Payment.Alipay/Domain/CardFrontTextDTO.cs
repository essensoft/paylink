using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardFrontTextDTO Data Structure.
    /// </summary>
    public class CardFrontTextDTO : AlipayObject
    {
        /// <summary>
        /// 文案标签
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
