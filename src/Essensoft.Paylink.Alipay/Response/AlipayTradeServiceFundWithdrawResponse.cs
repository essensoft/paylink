using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayTradeServiceFundWithdrawResponse.
    /// </summary>
    public class AlipayTradeServiceFundWithdrawResponse : AlipayResponse
    {
        /// <summary>
        /// 实际提现金额,单位:元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔提现请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
