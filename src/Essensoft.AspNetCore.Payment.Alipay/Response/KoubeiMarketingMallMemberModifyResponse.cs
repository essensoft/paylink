using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyResponse.
    /// </summary>
    public class KoubeiMarketingMallMemberModifyResponse : AlipayResponse
    {
        /// <summary>
        /// true：成功，false：失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
