using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryReservationIsvorderSyncResponse.
    /// </summary>
    public class KoubeiServindustryReservationIsvorderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 表示接收成功或失败
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
