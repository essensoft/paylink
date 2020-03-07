using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCreateResponse.
    /// </summary>
    public class AlipayTradeRepaybillOrderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 还款的资金单号，后续用该单号去调用支付宝收银台sdk进行支付
        /// </summary>
        [JsonPropertyName("repay_fund_order_no")]
        public string RepayFundOrderNo { get; set; }
    }
}
