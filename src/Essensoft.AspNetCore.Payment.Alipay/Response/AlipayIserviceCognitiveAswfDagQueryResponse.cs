using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveAswfDagQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveAswfDagQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonPropertyName("dag_id")]
        public string DagId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// true: 业务处理成功  false: 业务处理失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
