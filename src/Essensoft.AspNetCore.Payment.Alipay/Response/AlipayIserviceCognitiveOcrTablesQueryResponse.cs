using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrTablesQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrTablesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// true：识别成功  false: 识别失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 表格内容
        /// </summary>
        [JsonPropertyName("tables")]
        public List<AiOcrTableRow> Tables { get; set; }

        /// <summary>
        /// 服务请求唯一标示id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
