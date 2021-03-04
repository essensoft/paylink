using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialCreateResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
