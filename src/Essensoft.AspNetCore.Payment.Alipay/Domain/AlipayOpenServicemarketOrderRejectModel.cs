using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderRejectModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderRejectModel : AlipayObject
    {
        /// <summary>
        /// 订购服务商品订单ID
        /// </summary>
        [JsonPropertyName("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 拒绝接单原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
