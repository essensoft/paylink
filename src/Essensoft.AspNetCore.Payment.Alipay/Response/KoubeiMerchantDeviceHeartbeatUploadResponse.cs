using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantDeviceHeartbeatUploadResponse.
    /// </summary>
    public class KoubeiMerchantDeviceHeartbeatUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 接口调用是否重试的标识
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 接口调用是否成功的标识
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
