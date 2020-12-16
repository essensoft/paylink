using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizResult Data Structure.
    /// </summary>
    public class BizResult : AlipayObject
    {
        /// <summary>
        /// 编码后的真实业务信息
        /// </summary>
        [JsonPropertyName("encoded_result_obj")]
        public string EncodedResultObj { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息，面向开发人员
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 中文错误信息，面向客户
        /// </summary>
        [JsonPropertyName("error_view_msg")]
        public string ErrorViewMsg { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 业务成功失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
