using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppStressHeartbeatUploadResponse.
    /// </summary>
    public class AlipayEbppStressHeartbeatUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 下一个状态的状态码
        /// </summary>
        [JsonPropertyName("next_status")]
        public string NextStatus { get; set; }

        /// <summary>
        /// 上报是否成功标识
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
