using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountTradeQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 买家ID
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 资金单明细
        /// </summary>
        [JsonPropertyName("trade_fund_bill_list")]
        public List<TradeFundBillDetail> TradeFundBillList { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [JsonPropertyName("trade_status")]
        public string TradeStatus { get; set; }
    }
}
