using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebInitializeResponse.
    /// </summary>
    public class ZolozIdentificationUserWebInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [JsonPropertyName("extern_info")]
        public string ExternInfo { get; set; }

        /// <summary>
        /// 刷脸认证的唯一标识
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }
    }
}
