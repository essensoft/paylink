using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
