using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryReservationShopUnbindResponse.
    /// </summary>
    public class KoubeiServindustryReservationShopUnbindResponse : AlipayResponse
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
        /// 业务是否 成功true，失败false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
