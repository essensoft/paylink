using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationIsvorderSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryReservationIsvorderSyncModel : AlipayObject
    {
        /// <summary>
        /// 用户到店时间
        /// </summary>
        [JsonPropertyName("arrive_time")]
        public string ArriveTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 预订订单订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户在口碑开店后的门店号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
