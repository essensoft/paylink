using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayVirtualcardSendResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayVirtualcardSendResponse : AlipayResponse
    {
        /// <summary>
        /// 用户虚拟卡卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片跳转地址
        /// </summary>
        [JsonPropertyName("card_schema")]
        public string CardSchema { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [JsonPropertyName("sub_error_code")]
        public string SubErrorCode { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
