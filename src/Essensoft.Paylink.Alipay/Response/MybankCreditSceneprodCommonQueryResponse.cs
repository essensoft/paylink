using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodCommonQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodCommonQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 请求结果响应说明唯一序号，包含多个字符串
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }

        /// <summary>
        /// 支付宝账号不存在。
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 请求是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 请求响应唯一描述
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
