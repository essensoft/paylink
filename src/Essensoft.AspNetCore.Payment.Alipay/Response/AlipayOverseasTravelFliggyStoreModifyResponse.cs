using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyStoreModifyResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyStoreModifyResponse : AlipayResponse
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
        /// 回调处理是否成功，true标示处理成功，false标示处理失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
