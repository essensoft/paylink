using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppFlowStatusQueryResponse.
    /// </summary>
    public class AlipayEbppFlowStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonPropertyName("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 订单状态  S:成功  F:失败  P:处理中
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 外表订单号
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }
    }
}
