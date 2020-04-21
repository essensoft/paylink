using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiResponseHeader Data Structure.
    /// </summary>
    public class OpenApiResponseHeader : AlipayObject
    {
        /// <summary>
        /// 自定义状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 子状态码
        /// </summary>
        [JsonPropertyName("sub_status_code")]
        public string SubStatusCode { get; set; }
    }
}
