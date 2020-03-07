using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntProdpaasArrangementRebateRateQueryResponse.
    /// </summary>
    public class AntProdpaasArrangementRebateRateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 一级类目ID
        /// </summary>
        [JsonPropertyName("category_1_id")]
        public string Category1Id { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [JsonPropertyName("category_1_name")]
        public string Category1Name { get; set; }

        /// <summary>
        /// 结束时间，精确到天
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 开始时间，精确到天
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 费率
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }
    }
}
