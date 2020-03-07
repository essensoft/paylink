using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyConfirmModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskPolicyConfirmModel : AlipayObject
    {
        /// <summary>
        /// 二次确认参数，防止篡改
        /// </summary>
        [JsonPropertyName("confirm_params")]
        public string ConfirmParams { get; set; }

        /// <summary>
        /// 安全请求生成的唯一ID
        /// </summary>
        [JsonPropertyName("security_id")]
        public string SecurityId { get; set; }
    }
}
