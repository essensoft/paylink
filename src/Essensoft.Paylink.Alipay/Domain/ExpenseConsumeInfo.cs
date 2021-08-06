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
        /// 账单类型（CONSUME-消费账单、REFUND-退款、TRANSFER-转账）
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单行业分类（交通出行，餐饮美食，商业服务，日用百货等等）
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
        /// 费控制度中的项目编号
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 支付使用的项目号（成本中心）此字段废弃
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
