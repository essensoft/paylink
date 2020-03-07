using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationCategorySyncResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationCategorySyncResponse : AlipayResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [JsonPropertyName("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否正确
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
