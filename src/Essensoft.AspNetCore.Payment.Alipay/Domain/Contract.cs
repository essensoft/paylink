using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Contract Data Structure.
    /// </summary>
    public class Contract : AlipayObject
    {
        /// <summary>
        /// 合约文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 合约标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
