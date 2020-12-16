using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransPayResponse.
    /// </summary>
    public class AlipayFundTransPayResponse : AlipayResponse
    {
        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [JsonPropertyName("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// SUCCESS：支付成功；  FAIL：支付失败；  UNKNOWN：未知；建议通过查询确认最新状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("trans_pay_time")]
        public string TransPayTime { get; set; }
    }
}
