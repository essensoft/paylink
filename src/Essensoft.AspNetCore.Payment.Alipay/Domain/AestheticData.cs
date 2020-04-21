using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AestheticData Data Structure.
    /// </summary>
    public class AestheticData : AlipayObject
    {
        /// <summary>
        /// 返回执行信息，包括成功和错误
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 图片的美学评估得分
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 标识返回结果，0表示成功 1表示异常
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用于标识当次请求
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
