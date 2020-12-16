using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceIdentityInitializeResponse.
    /// </summary>
    public class AlipayEbppInstserviceIdentityInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 核身字符串
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
