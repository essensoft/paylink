using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HbMeiWeishopInfo Data Structure.
    /// </summary>
    public class HbMeiWeishopInfo : AlipayObject
    {
        /// <summary>
        /// 所在城市code
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 所在城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 平均金额,单位为分
        /// </summary>
        [JsonPropertyName("pirce_per_avg_shop")]
        public long PircePerAvgShop { get; set; }

        /// <summary>
        /// 商圈信息
        /// </summary>
        [JsonPropertyName("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 所在省份code
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 商家经纬度地址
        /// </summary>
        [JsonPropertyName("shop_gis")]
        public string ShopGis { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家星级
        /// </summary>
        [JsonPropertyName("star_rate_shop")]
        public string StarRateShop { get; set; }
    }
}
