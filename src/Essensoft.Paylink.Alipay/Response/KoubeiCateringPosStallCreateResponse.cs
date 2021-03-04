using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosStallCreateResponse.
    /// </summary>
    public class KoubeiCateringPosStallCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
