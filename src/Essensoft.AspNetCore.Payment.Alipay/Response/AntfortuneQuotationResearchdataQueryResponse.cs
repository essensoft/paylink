using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneQuotationResearchdataQueryResponse.
    /// </summary>
    public class AntfortuneQuotationResearchdataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 金融信息数据返回值，datatable的json形式。
        /// </summary>
        [JsonPropertyName("result_content")]
        public string ResultContent { get; set; }

        /// <summary>
        /// 结果的描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否本次请求成功
        /// </summary>
        [JsonPropertyName("result_success")]
        public bool ResultSuccess { get; set; }
    }
}
