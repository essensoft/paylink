using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApMonthlyBillCustOpenApiResponse Data Structure.
    /// </summary>
    public class ApMonthlyBillCustOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 分析维度1
        /// </summary>
        [JsonPropertyName("analysis_dmsn_1")]
        public string AnalysisDmsn1 { get; set; }

        /// <summary>
        /// 分析维度2
        /// </summary>
        [JsonPropertyName("analysis_dmsn_2")]
        public string AnalysisDmsn2 { get; set; }

        /// <summary>
        /// 分析维度3
        /// </summary>
        [JsonPropertyName("analysis_dmsn_3")]
        public string AnalysisDmsn3 { get; set; }

        /// <summary>
        /// 分析维度4
        /// </summary>
        [JsonPropertyName("analysis_dmsn_4")]
        public string AnalysisDmsn4 { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 认证关联发票金额
        /// </summary>
        [JsonPropertyName("auth_invoice_amt")]
        public MultiCurrencyMoneyOpenApi AuthInvoiceAmt { get; set; }

        /// <summary>
        /// 账单关联发票状态[01-未关联；02-部分关联；03-完全关联]
        /// </summary>
        [JsonPropertyName("bill_invoice_link_status")]
        public string BillInvoiceLinkStatus { get; set; }

        /// <summary>
        /// 账单月份(yyyyMM)
        /// </summary>
        [JsonPropertyName("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 月账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 账单结束日期(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 止付金额
        /// </summary>
        [JsonPropertyName("fbd_pay_amt")]
        public MultiCurrencyMoneyOpenApi FbdPayAmt { get; set; }

        /// <summary>
        /// 止付类型（通常为空）{"01":"客户级别止付","02":"用户级别止付","03":"账单级别止付","04":"用户产品级别止付","05":"客户产品级别止付","99":"未止付"}
        /// </summary>
        [JsonPropertyName("fbd_pay_type")]
        public string FbdPayType { get; set; }

        /// <summary>
        /// 分支机构ID（OU标识）
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 关联发票金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 签约对象PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 结算对象名称
        /// </summary>
        [JsonPropertyName("ip_role_name")]
        public string IpRoleName { get; set; }

        /// <summary>
        /// 签约对象MID（非商户时为空）
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 已付金额
        /// </summary>
        [JsonPropertyName("paid_amt")]
        public MultiCurrencyMoneyOpenApi PaidAmt { get; set; }

        /// <summary>
        /// 付款渠道：银行账号 、支付宝账号、国际银行卡
        /// </summary>
        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 付款状态[01-待结算；02-部分结算；03-结算完成]
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("pd_name")]
        public string PdName { get; set; }

        /// <summary>
        /// 计价标识
        /// </summary>
        [JsonPropertyName("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 价格名
        /// </summary>
        [JsonPropertyName("price_name")]
        public string PriceName { get; set; }

        /// <summary>
        /// 价格政策ID
        /// </summary>
        [JsonPropertyName("price_policy_id")]
        public string PricePolicyId { get; set; }

        /// <summary>
        /// 价格政策名
        /// </summary>
        [JsonPropertyName("price_policy_name")]
        public string PricePolicyName { get; set; }

        /// <summary>
        /// 客户可见账单金额 = 账单确认金额 + 汇总调整确认金额 + 明细调整确认金额
        /// </summary>
        [JsonPropertyName("real_bill_amt")]
        public MultiCurrencyMoneyOpenApi RealBillAmt { get; set; }

        /// <summary>
        /// 结算类型，01-实时，02-后付，03-周期性
        /// </summary>
        [JsonPropertyName("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 账单开始日期(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }
    }
}
