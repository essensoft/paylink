using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoCertifyResponse.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有默认收款卡号
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 验证是否通过
        /// </summary>
        [JsonPropertyName("is_pass")]
        public bool IsPass { get; set; }
    }
}
