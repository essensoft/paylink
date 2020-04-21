using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeItemorderRefundResponse.
    /// </summary>
    public class KoubeiTradeItemorderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款唯一请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 实际退的资金。
        /// </summary>
        [JsonPropertyName("real_refund_amount")]
        public string RealRefundAmount { get; set; }
    }
}
