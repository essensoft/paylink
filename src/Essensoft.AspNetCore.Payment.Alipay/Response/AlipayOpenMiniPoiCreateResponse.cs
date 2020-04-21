using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniPoiCreateResponse.
    /// </summary>
    public class AlipayOpenMiniPoiCreateResponse : AlipayResponse
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }
    }
}
