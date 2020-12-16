using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationObjectQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationObjectQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 识别类型
        /// </summary>
        [JsonPropertyName("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [JsonPropertyName("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 关键字识别列表
        /// </summary>
        [JsonPropertyName("key_words")]
        public List<ObjectKeyWord> KeyWords { get; set; }

        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonPropertyName("origin_content")]
        public string OriginContent { get; set; }

        /// <summary>
        /// 平台实际使用内容
        /// </summary>
        [JsonPropertyName("rewrite_content")]
        public string RewriteContent { get; set; }

        /// <summary>
        /// 接口是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// trace
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
