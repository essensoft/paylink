using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeBindResponse : AlipayResponse
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
