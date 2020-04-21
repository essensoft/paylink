using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosStallModifyResponse.
    /// </summary>
    public class KoubeiCateringPosStallModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
