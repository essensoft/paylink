using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataDeerInsightQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDeerInsightQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 凤蝶洞察信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
