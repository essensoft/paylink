using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataSearchlibraryBaiQueryResponse.
    /// </summary>
    public class AlipayDataIotdataSearchlibraryBaiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 采用的模型以及版本说明
        /// </summary>
        [JsonPropertyName("model_info")]
        public string ModelInfo { get; set; }

        /// <summary>
        /// 重复列表，json list格式
        /// </summary>
        [JsonPropertyName("repeat_info")]
        public string RepeatInfo { get; set; }

        /// <summary>
        /// 相似度信息列表，json list格式
        /// </summary>
        [JsonPropertyName("similarity_info")]
        public string SimilarityInfo { get; set; }
    }
}
