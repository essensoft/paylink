using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyAuthorityQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyAuthorityQueryResponse : AlipayResponse
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
        /// 是否有权限，true有权限，false无权限
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
