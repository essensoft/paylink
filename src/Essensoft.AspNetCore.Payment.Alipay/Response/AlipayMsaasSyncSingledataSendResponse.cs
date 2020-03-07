using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasSyncSingledataSendResponse.
    /// </summary>
    public class AlipayMsaasSyncSingledataSendResponse : AlipayResponse
    {
        /// <summary>
        /// SYNC内部业务数据ID
        /// </summary>
        [JsonPropertyName("oplog_id")]
        public string OplogId { get; set; }

        /// <summary>
        /// 返回结果代码
        /// </summary>
        [JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回结果含义
        /// </summary>
        [JsonPropertyName("return_reason")]
        public string ReturnReason { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
