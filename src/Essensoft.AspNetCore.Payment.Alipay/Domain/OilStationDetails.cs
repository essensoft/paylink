using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OilStationDetails Data Structure.
    /// </summary>
    public class OilStationDetails : AlipayObject
    {
        /// <summary>
        /// 油站详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 直降金额
        /// </summary>
        [JsonPropertyName("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 油站名称
        /// </summary>
        [JsonPropertyName("oil_station_name")]
        public string OilStationName { get; set; }

        /// <summary>
        /// 油品
        /// </summary>
        [JsonPropertyName("oil_type")]
        public string OilType { get; set; }

        /// <summary>
        /// 高德 poi_id
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 油价，以元为单位
        /// </summary>
        [JsonPropertyName("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 油站门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
