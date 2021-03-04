using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 手艺人id
        /// </summary>
        [JsonPropertyName("craftsman_id")]
        public string CraftsmanId { get; set; }
    }
}
