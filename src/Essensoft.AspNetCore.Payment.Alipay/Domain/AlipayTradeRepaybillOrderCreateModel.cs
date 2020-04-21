using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayTradeRepaybillOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 还款的外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 还款的付款方用户id
        /// </summary>
        [JsonPropertyName("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 还款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 还款单的收款方名称
        /// </summary>
        [JsonPropertyName("repay_payee_name")]
        public string RepayPayeeName { get; set; }

        /// <summary>
        /// 还款的收单产品码，支付宝定义
        /// </summary>
        [JsonPropertyName("repay_product_code")]
        public string RepayProductCode { get; set; }

        /// <summary>
        /// 还款说明
        /// </summary>
        [JsonPropertyName("repay_remark")]
        public string RepayRemark { get; set; }

        /// <summary>
        /// 该笔还款单允许的最晚还款时间，逾期将关闭订单。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [JsonPropertyName("repay_timeout_express")]
        public string RepayTimeoutExpress { get; set; }
    }
}
