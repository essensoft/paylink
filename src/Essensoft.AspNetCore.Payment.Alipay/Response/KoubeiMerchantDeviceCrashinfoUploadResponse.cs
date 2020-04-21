using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantDeviceCrashinfoUploadResponse.
    /// </summary>
    public class KoubeiMerchantDeviceCrashinfoUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 系统错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// "错误信息描述"
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
