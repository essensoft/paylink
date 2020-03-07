using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataRiskRtopobtsregQueryResponse.
    /// </summary>
    public class AlipayDataRiskRtopobtsregQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询后端ssdataprod应用的返回数据
        /// </summary>
        [JsonPropertyName("query_result")]
        public string QueryResult { get; set; }

        /// <summary>
        /// 调用是否成功标识
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// unqiue_id+业务唯一识别码traceId
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
