using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundDetail Data Structure.
    /// </summary>
    public class RefundDetail : AlipayObject
    {
        /// <summary>
        /// 交易退款金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [JsonPropertyName("refund_memo")]
        public string RefundMemo { get; set; }

        /// <summary>
        /// 退分润列表
        /// </summary>
        [JsonPropertyName("refund_royaltys")]
        public List<RefundRoyaltyInfo> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退补差金额
        /// </summary>
        [JsonPropertyName("refund_suppl_amount")]
        public string RefundSupplAmount { get; set; }

        /// <summary>
        /// 退补差备注
        /// </summary>
        [JsonPropertyName("refund_suppl_memo")]
        public string RefundSupplMemo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
