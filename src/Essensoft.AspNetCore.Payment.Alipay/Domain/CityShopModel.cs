using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CityShopModel Data Structure.
    /// </summary>
    public class CityShopModel : AlipayObject
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区id
        /// </summary>
        [JsonPropertyName("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 判断门店是否是简易门店
        /// </summary>
        [JsonPropertyName("pos_shop")]
        public bool PosShop { get; set; }

        /// <summary>
        /// 省份id
        /// </summary>
        [JsonPropertyName("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [JsonPropertyName("shop_status")]
        public string ShopStatus { get; set; }
    }
}
