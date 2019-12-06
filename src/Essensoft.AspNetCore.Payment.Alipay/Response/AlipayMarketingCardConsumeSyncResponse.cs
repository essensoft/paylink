using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardConsumeSyncResponse.
    /// </summary>
    public class AlipayMarketingCardConsumeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 外部卡号
        /// </summary>
        [JsonPropertyName("external_card_no")]
        public string ExternalCardNo { get; set; }
    }
}
