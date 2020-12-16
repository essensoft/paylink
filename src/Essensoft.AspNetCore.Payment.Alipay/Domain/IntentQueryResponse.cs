using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntentQueryResponse Data Structure.
    /// </summary>
    public class IntentQueryResponse : AlipayObject
    {
        /// <summary>
        /// 对应用户的queryId
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果编码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果json
        /// </summary>
        [JsonPropertyName("result_json")]
        public string ResultJson { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
