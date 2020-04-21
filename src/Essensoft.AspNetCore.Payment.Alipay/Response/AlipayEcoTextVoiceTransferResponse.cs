using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoTextVoiceTransferResponse.
    /// </summary>
    public class AlipayEcoTextVoiceTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 阿里云语音编号
        /// </summary>
        [JsonPropertyName("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 调用结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 调用结果描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
