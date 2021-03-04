using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
