using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupFundUserBill Data Structure.
    /// </summary>
    public class GroupFundUserBill : AlipayObject
    {
        /// <summary>
        /// 实际待收待付金额，两位小数点的整数，单位元
        /// </summary>
        [JsonPropertyName("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 待收或待付金额，两位小数点的正数，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 团体资金批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次状态,包括: INIT:收款中, COLLECT_SUC: 全部收款完成, PAYMENT_SUC: 全部付款完成, CLOSE: 超时收款未完成已关闭，REFUND：付款部分未成功,部分退款
        /// </summary>
        [JsonPropertyName("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 资金单据号，唯一标识一次资金流入/流出
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 单据类型, "R"为收款单，"P"为付款单
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 单据状态，包括"INIT": 初始化(发起预结算尚未预付款)，"PRE_PAY": 预付款阶段，"PAY_SUC"：预付款成功，"CLOSE"：已关闭，"REFUND"：已退款
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 批次是否过期
        /// </summary>
        [JsonPropertyName("timeout")]
        public bool Timeout { get; set; }

        /// <summary>
        /// 单据所属的支付宝账户ID，对于收款单表示待付款用户ID，对于付款单标识待收款用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
