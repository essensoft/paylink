using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVenueQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商场馆ID
        /// </summary>
        [JsonPropertyName("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 支付宝场馆ID
        /// </summary>
        [JsonPropertyName("venue_id")]
        public string VenueId { get; set; }
    }
}
