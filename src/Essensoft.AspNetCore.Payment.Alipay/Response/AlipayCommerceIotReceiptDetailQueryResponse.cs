using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotReceiptDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceIotReceiptDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 电子小票详情信息
        /// </summary>
        [JsonPropertyName("data")]
        public ReceiptDetailInfo Data { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 返回子码
        /// </summary>
        [JsonPropertyName("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [JsonPropertyName("ret_message")]
        public string RetMessage { get; set; }

        /// <summary>
        /// 返回子消息
        /// </summary>
        [JsonPropertyName("ret_message_sub")]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// 调用是否成功(true/false)
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
