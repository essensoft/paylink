using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMessageMatcherSendResponse.
    /// </summary>
    public class AlipayMobileStdPublicMessageMatcherSendResponse : AlipayResponse
    {
        /// <summary>
        /// 对应toUserId，标准Alipay UserId
        /// </summary>
        [JsonPropertyName("to_alipay_user_id")]
        public string ToAlipayUserId { get; set; }

        /// <summary>
        /// 消息接收人的用户ID，值取的openId
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }
    }
}
