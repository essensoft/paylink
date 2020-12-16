using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillModifyModel Data Structure.
    /// </summary>
    public class AlipayTradeRepaybillModifyModel : AlipayObject
    {
        /// <summary>
        /// 要修改的目标相对金额； 如果要在原先的金额上增加则使用正数，要在原来的基础上减少则使用负数。注意：只有operation_type为金额修改类操作，这个值才有效
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝还款账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 要修改的账单状态，注意：只有operation_type为状态修改类操作，这个值才有效
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 该接口可以支持不同类型的修改操作，包括金额和账单状态。  MODIFY_BILL_AMOUNT ：修改账单金额； MODIFY_BILL_OVERDUE_AMOUNT： 修改账单逾期罚息金额； MODIFY_PAID_AMOUNT：修改账单金额； MODIFY_REVOKE_AMOUNT：修改还款前撤销金额； MODIFY_PAID_REVOKE_AMOUNT：修改支付撤销金额； MODIFY_BILL_STATUS：修改账单状态
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 本次修改请求的请求号，用于做幂等控制，针对同一笔账单做不同修改out_request_no不能相同，如果相同则代表是重复请求
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
