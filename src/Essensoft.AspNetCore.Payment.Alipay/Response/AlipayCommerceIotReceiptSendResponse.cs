using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotReceiptSendResponse.
    /// </summary>
    public class AlipayCommerceIotReceiptSendResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段，暂时不用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 小票id
        /// </summary>
        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

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
        /// 调用成功失败（true/false）
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
