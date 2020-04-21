using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppBillRefundModel Data Structure.
    /// </summary>
    public class AlipayEbppBillRefundModel : AlipayObject
    {
        /// <summary>
        /// 支付宝流水号。
        /// </summary>
        [JsonPropertyName("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 扩展字段，json格式的一系列键值对，示例只是个形式，具体的Key-Value需要根据具体业务另行约定。  无特别约定时，此字段不必传。
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// ISV流水号，用于控制幂等，须确保全局唯一（缴税业务：可采用{征收机关代码}-{外部申报号}的形式）  out_order_no与alipay_bill_no二者中至少要传一个
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位：元  不可超过创单时的金额。  如果scene是TOTAL_FAILURE，则强制要求全额退款，不支持部分退款。
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款来源账户。  仅在退款请求对应的业务流水资金已经结算的情况下有用，不指定则不能对已结算业务流水发起退款。  取值可以给定受管控账户2088****************，需要事先在支付宝备案通过方可使用；亦可以填入THIS_ACCOUNT，表示会从当前调用者的账户退款给用户。
        /// </summary>
        [JsonPropertyName("refund_from")]
        public string RefundFrom { get; set; }

        /// <summary>
        /// 退款场景，不同场景由不同策略处理。  OVERPAYMENT：退掉用户多支付的金额  PARTIALLY_DONE：业务上部分失败导致退款  TOTAL_FAILURE：完全失败导致的退款
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
