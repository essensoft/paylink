using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportMessageSendResponse.
    /// </summary>
    public class AlipayCommerceTransportMessageSendResponse : AlipayResponse
    {
        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 失败的支付宝用户id列表。
        /// </summary>
        [JsonPropertyName("failed_user_ids")]
        public string FailedUserIds { get; set; }
    }
}
