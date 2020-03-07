using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskOfflinevarsQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskOfflinevarsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果，包含所有维度的结果数据，两层json格式
        /// </summary>
        [JsonPropertyName("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 调用是否成功标识
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
