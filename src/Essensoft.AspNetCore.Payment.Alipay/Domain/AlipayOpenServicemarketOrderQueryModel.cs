using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户订单ID号
        /// </summary>
        [JsonPropertyName("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 从第几页开始查询
        /// </summary>
        [JsonPropertyName("start_page")]
        public string StartPage { get; set; }
    }
}
