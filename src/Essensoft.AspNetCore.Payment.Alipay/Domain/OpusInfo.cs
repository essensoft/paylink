using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpusInfo Data Structure.
    /// </summary>
    public class OpusInfo : AlipayObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙;默认值为0
        /// </summary>
        [JsonPropertyName("display_weight")]
        public string DisplayWeight { get; set; }

        /// <summary>
        /// 外部作品id
        /// </summary>
        [JsonPropertyName("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举类型：PICTURE/VIDEO
        /// </summary>
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 素材url
        /// </summary>
        [JsonPropertyName("media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [JsonPropertyName("opus_id")]
        public string OpusId { get; set; }

        /// <summary>
        /// 素材标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
