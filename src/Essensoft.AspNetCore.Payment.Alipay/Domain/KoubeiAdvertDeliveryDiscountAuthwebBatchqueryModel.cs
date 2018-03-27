using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountAuthwebBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountAuthwebBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 分配的固定的渠道CODE，需要找运营申请
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 纬度，根据经纬度查询附近的券
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，根据经纬度查询附近的券
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店ID，如果设置门店，则查询门店下发行的券
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
