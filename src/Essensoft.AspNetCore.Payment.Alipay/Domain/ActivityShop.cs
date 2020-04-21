using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityShop Data Structure.
    /// </summary>
    public class ActivityShop : AlipayObject
    {
        /// <summary>
        /// 承诺消费活动门店地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 承诺消费活动门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 承诺消费门店纬度
        /// </summary>
        [JsonPropertyName("shop_latitude")]
        public string ShopLatitude { get; set; }

        /// <summary>
        /// 承诺消费门店经度信息
        /// </summary>
        [JsonPropertyName("shop_longitude")]
        public string ShopLongitude { get; set; }

        /// <summary>
        /// 承诺消费活动门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
