using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 如果成功，返回Y
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
