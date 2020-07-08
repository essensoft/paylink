using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 响应对象
    /// </summary>
    public abstract class WeChatPayResponse : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// HTTP状态码
        /// </summary>
        [JsonIgnore]
        public int StatusCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误详情
        /// </summary>
        [JsonPropertyName("detail")]
        public ErrorDetail Detail { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
