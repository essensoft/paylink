using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromoContentBizVO Data Structure.
    /// </summary>
    public class PromoContentBizVO : AlipayObject
    {
        /// <summary>
        /// 具体内容信息
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容元数据ID
        /// </summary>
        [JsonPropertyName("meta_id")]
        public string MetaId { get; set; }

        /// <summary>
        /// 内容的具体类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
