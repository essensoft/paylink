using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyPoiCreateResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyPoiCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息提示
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回调结果的结果标示
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
