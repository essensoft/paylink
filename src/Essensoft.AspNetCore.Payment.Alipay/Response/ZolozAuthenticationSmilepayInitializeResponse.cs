using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationSmilepayInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationSmilepayInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回详细码
        /// </summary>
        [JsonPropertyName("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [JsonPropertyName("ret_message_sub")]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// ZIM上下文ID
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }

        /// <summary>
        /// 客户端协议
        /// </summary>
        [JsonPropertyName("zim_init_client_data")]
        public string ZimInitClientData { get; set; }
    }
}
