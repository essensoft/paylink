using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayOrderQueryVO Data Structure.
    /// </summary>
    public class CreditPayOrderQueryVO : AlipayObject
    {
        /// <summary>
        /// 已入账金额
        /// </summary>
        [JsonPropertyName("acc_amt")]
        public long AccAmt { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [JsonPropertyName("pay_amt")]
        public long PayAmt { get; set; }

        /// <summary>
        /// 支付收单订单号
        /// </summary>
        [JsonPropertyName("pay_order_no")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 入账后退款金额，单位分
        /// </summary>
        [JsonPropertyName("refund_af_acc_amt")]
        public long RefundAfAccAmt { get; set; }

        /// <summary>
        /// 入账前退款金额，单位分
        /// </summary>
        [JsonPropertyName("refund_bef_acc_amt")]
        public long RefundBefAccAmt { get; set; }

        /// <summary>
        /// 用户已还款金额（非退款导致，如主动还款和批扣），单位分
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public long RepayAmt { get; set; }
    }
}
