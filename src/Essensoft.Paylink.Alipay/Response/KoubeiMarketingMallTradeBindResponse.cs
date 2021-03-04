using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
