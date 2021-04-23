using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SalesData Data Structure.
    /// </summary>
    public class SalesData : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 当日销售订单数
        /// </summary>
        [JsonPropertyName("order_count")]
        public string OrderCount { get; set; }

        /// <summary>
        /// 当日退款订单数
        /// </summary>
        [JsonPropertyName("refund_order_count")]
        public string RefundOrderCount { get; set; }

        /// <summary>
        /// 当日退款金额
        /// </summary>
        [JsonPropertyName("refund_sales_amount")]
        public string RefundSalesAmount { get; set; }

        /// <summary>
        /// 当日销售额
        /// </summary>
        [JsonPropertyName("sales_amount")]
        public string SalesAmount { get; set; }
    }
}
