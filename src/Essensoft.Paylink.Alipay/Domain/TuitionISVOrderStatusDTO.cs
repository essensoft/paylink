using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TuitionISVOrderStatusDTO Data Structure.
    /// </summary>
    public class TuitionISVOrderStatusDTO : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; }
    }
}
