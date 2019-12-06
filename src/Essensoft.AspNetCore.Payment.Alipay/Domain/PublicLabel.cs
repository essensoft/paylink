using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PublicLabel Data Structure.
    /// </summary>
    public class PublicLabel : AlipayObject
    {
        /// <summary>
        /// 标签用户量
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 标签编号
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
