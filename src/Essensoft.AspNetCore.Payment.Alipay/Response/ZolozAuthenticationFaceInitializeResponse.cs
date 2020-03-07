using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationFaceInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationFaceInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 由客户端解析的非明文字符串数据
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

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
        /// zim唯一标识
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }
    }
}
