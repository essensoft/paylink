using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingSearchcodeCreateResponse.
    /// </summary>
    public class AlipayMarketingSearchcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 搜索码后边拼接的文案
        /// </summary>
        [JsonPropertyName("end_content")]
        public string EndContent { get; set; }

        /// <summary>
        /// box搜索品牌词
        /// </summary>
        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// 搜索口令前边拼接文案
        /// </summary>
        [JsonPropertyName("pre_content")]
        public string PreContent { get; set; }

        /// <summary>
        /// 搜索口令值
        /// </summary>
        [JsonPropertyName("search_code")]
        public string SearchCode { get; set; }
    }
}
