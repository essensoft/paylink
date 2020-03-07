using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppRechargeFlowSendResponse.
    /// </summary>
    public class AlipayEbppRechargeFlowSendResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部交易号
        /// </summary>
        [JsonPropertyName("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// P:已接受，处理中  F:兑换上送失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 外部交易id
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }
    }
}
