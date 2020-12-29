using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 广告分组标识
        /// </summary>
        [JsonPropertyName("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonPropertyName("advert_id")]
        public string AdvertId { get; set; }
    }
}
