using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountWebBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountWebBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 分配的固定的渠道CODE，需要找运营申请
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 纬度，根据经纬度查询附近的券
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，根据经纬度查询附近的券
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 手机号码，根据手机号码查询支付宝账户ID
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 门店ID，如果设置门店，则查询门店下发行的券
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
