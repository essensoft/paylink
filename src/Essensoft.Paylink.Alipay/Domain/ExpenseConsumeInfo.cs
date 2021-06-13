using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExpenseConsumeInfo Data Structure.
    /// </summary>
    public class ExpenseConsumeInfo : AlipayObject
    {
        /// <summary>
        /// 公司账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单类型（支付、退款、转账）
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单分类
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("consume_amount")]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        [JsonPropertyName("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 账单展示标题
        /// </summary>
        [JsonPropertyName("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 所属员工支付宝uid
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业代付金额
        /// </summary>
        [JsonPropertyName("p_pay_amount")]
        public string PPayAmount { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 支付使用的项目号（成本中心）
        /// </summary>
        [JsonPropertyName("projiect_id")]
        public string ProjiectId { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
