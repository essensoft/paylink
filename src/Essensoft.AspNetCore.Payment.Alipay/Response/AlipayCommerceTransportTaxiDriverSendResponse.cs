using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverSendResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverSendResponse : AlipayResponse
    {
        /// <summary>
        /// 司机身份证号
        /// </summary>
        [JsonPropertyName("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
