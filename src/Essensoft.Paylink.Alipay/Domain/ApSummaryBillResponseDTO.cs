using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApSummaryBillResponseDTO Data Structure.
    /// </summary>
    public class ApSummaryBillResponseDTO : AlipayObject
    {
        /// <summary>
        /// 调账金额
        /// </summary>
        [JsonPropertyName("adjust_amount")]
        public MultiCurrencyMoneyOpenApi AdjustAmount { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 自动确认日期
        /// </summary>
        [JsonPropertyName("auto_confirm_date")]
        public string AutoConfirmDate { get; set; }

        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public MultiCurrencyMoneyOpenApi BillAmount { get; set; }

        /// <summary>
        /// 账单结束日期
        /// </summary>
        [JsonPropertyName("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单月份
        /// </summary>
        [JsonPropertyName("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单编码
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单起始日期
        /// </summary>
        [JsonPropertyName("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [JsonPropertyName("bill_status_name")]
        public string BillStatusName { get; set; }

        /// <summary>
        /// 业务模块
        /// </summary>
        [JsonPropertyName("biz_module")]
        public string BizModule { get; set; }

        /// <summary>
        /// 业财产品码
        /// </summary>
        [JsonPropertyName("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("ccy_code")]
        public string CcyCode { get; set; }

        /// <summary>
        /// 收费项编码
        /// </summary>
        [JsonPropertyName("charge_item_code")]
        public string ChargeItemCode { get; set; }

        /// <summary>
        /// 出账周期
        /// </summary>
        [JsonPropertyName("charge_off_period")]
        public string ChargeOffPeriod { get; set; }

        /// <summary>
        /// 出账周期类型
        /// </summary>
        [JsonPropertyName("charge_off_period_type")]
        public string ChargeOffPeriodType { get; set; }

        /// <summary>
        /// 出账周期类型name
        /// </summary>
        [JsonPropertyName("charge_off_period_type_name")]
        public string ChargeOffPeriodTypeName { get; set; }

        /// <summary>
        /// 出账日期
        /// </summary>
        [JsonPropertyName("check_date")]
        public string CheckDate { get; set; }

        /// <summary>
        /// 计费服务量
        /// </summary>
        [JsonPropertyName("clcn_basic_amount")]
        public string ClcnBasicAmount { get; set; }

        /// <summary>
        /// 计费服务类型
        /// </summary>
        [JsonPropertyName("clcn_basic_type")]
        public string ClcnBasicType { get; set; }

        /// <summary>
        /// 计费服务类型
        /// </summary>
        [JsonPropertyName("clcn_basic_type_name")]
        public string ClcnBasicTypeName { get; set; }

        /// <summary>
        /// 已确认金额
        /// </summary>
        [JsonPropertyName("confirmed_amount")]
        public MultiCurrencyMoneyOpenApi ConfirmedAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("exclude_tax_amount")]
        public MultiCurrencyMoneyOpenApi ExcludeTaxAmount { get; set; }

        /// <summary>
        /// 结算时点
        /// </summary>
        [JsonPropertyName("fund_settle_time")]
        public string FundSettleTime { get; set; }

        /// <summary>
        /// 关联方标志
        /// </summary>
        [JsonPropertyName("inner_trade_flag")]
        public string InnerTradeFlag { get; set; }

        /// <summary>
        /// 结算机构ou
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 关联发票状态
        /// </summary>
        [JsonPropertyName("invoice_status_desc")]
        public string InvoiceStatusDesc { get; set; }

        /// <summary>
        /// 已收票金额
        /// </summary>
        [JsonPropertyName("invoiced_amount")]
        public MultiCurrencyMoneyOpenApi InvoicedAmount { get; set; }

        /// <summary>
        /// 已回票金额 （结算单关联的发票金额）
        /// </summary>
        [JsonPropertyName("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 收款方账号扩展信息
        /// </summary>
        [JsonPropertyName("payee_account_ext_info")]
        public MapTypeParam PayeeAccountExtInfo { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [JsonPropertyName("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 收款方账号类型
        /// </summary>
        [JsonPropertyName("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款方账号类型 name
        /// </summary>
        [JsonPropertyName("payee_account_type_name")]
        public string PayeeAccountTypeName { get; set; }

        /// <summary>
        /// 收款对象pid
        /// </summary>
        [JsonPropertyName("payee_ip_role_id")]
        public string PayeeIpRoleId { get; set; }

        /// <summary>
        /// 收款对象pid来源
        /// </summary>
        [JsonPropertyName("payee_ip_role_id_source")]
        public string PayeeIpRoleIdSource { get; set; }

        /// <summary>
        /// 付款方账号扩展信息
        /// </summary>
        [JsonPropertyName("payer_account_ext_info")]
        public MapTypeParam PayerAccountExtInfo { get; set; }

        /// <summary>
        /// 付款账号
        /// </summary>
        [JsonPropertyName("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 付款方账号类型
        /// </summary>
        [JsonPropertyName("payer_account_type")]
        public string PayerAccountType { get; set; }

        /// <summary>
        /// 付款方账号类型名字
        /// </summary>
        [JsonPropertyName("payer_account_type_name")]
        public string PayerAccountTypeName { get; set; }

        /// <summary>
        /// 付款对象pid
        /// </summary>
        [JsonPropertyName("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 付款对象pid来源
        /// </summary>
        [JsonPropertyName("payer_ip_role_id_source")]
        public string PayerIpRoleIdSource { get; set; }

        /// <summary>
        /// 真实账单金额 = 账单金额 + 调账金额
        /// </summary>
        [JsonPropertyName("real_bill_amount")]
        public MultiCurrencyMoneyOpenApi RealBillAmount { get; set; }

        /// <summary>
        /// 对账状态
        /// </summary>
        [JsonPropertyName("reconciliation_status")]
        public string ReconciliationStatus { get; set; }

        /// <summary>
        /// 对账状态
        /// </summary>
        [JsonPropertyName("reconciliation_status_name")]
        public string ReconciliationStatusName { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("sales_product_code")]
        public string SalesProductCode { get; set; }

        /// <summary>
        /// 销售产品名称
        /// </summary>
        [JsonPropertyName("sales_product_name")]
        public string SalesProductName { get; set; }

        /// <summary>
        /// 结算业务类型
        /// </summary>
        [JsonPropertyName("settle_biz_type")]
        public string SettleBizType { get; set; }

        /// <summary>
        /// 结算业务类型name
        /// </summary>
        [JsonPropertyName("settle_biz_type_name")]
        public string SettleBizTypeName { get; set; }

        /// <summary>
        /// 结算对象pid
        /// </summary>
        [JsonPropertyName("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }

        /// <summary>
        /// 结算对象pid来源
        /// </summary>
        [JsonPropertyName("settle_ip_role_id_source")]
        public string SettleIpRoleIdSource { get; set; }

        /// <summary>
        /// 结算对象
        /// </summary>
        [JsonPropertyName("settle_ip_role_name")]
        public string SettleIpRoleName { get; set; }

        /// <summary>
        /// 结算对象mid
        /// </summary>
        [JsonPropertyName("settle_merchant_id")]
        public string SettleMerchantId { get; set; }

        /// <summary>
        /// 结算对象mid来源
        /// </summary>
        [JsonPropertyName("settle_merchant_id_source")]
        public string SettleMerchantIdSource { get; set; }

        /// <summary>
        /// 结算对象mid名称
        /// </summary>
        [JsonPropertyName("settle_merchant_name")]
        public string SettleMerchantName { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [JsonPropertyName("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [JsonPropertyName("settle_status_name")]
        public string SettleStatusName { get; set; }

        /// <summary>
        /// 结算时点类型
        /// </summary>
        [JsonPropertyName("settle_time_type")]
        public string SettleTimeType { get; set; }

        /// <summary>
        /// 结算时点类型name
        /// </summary>
        [JsonPropertyName("settle_time_type_name")]
        public string SettleTimeTypeName { get; set; }

        /// <summary>
        /// 已结算金额
        /// </summary>
        [JsonPropertyName("settled_amount")]
        public MultiCurrencyMoneyOpenApi SettledAmount { get; set; }

        /// <summary>
        /// 签约对象pid
        /// </summary>
        [JsonPropertyName("sign_ip_role_id")]
        public string SignIpRoleId { get; set; }

        /// <summary>
        /// 签约对象pid来源
        /// </summary>
        [JsonPropertyName("sign_ip_role_id_source")]
        public string SignIpRoleIdSource { get; set; }

        /// <summary>
        /// 签约对象mid
        /// </summary>
        [JsonPropertyName("sign_merchant_id")]
        public string SignMerchantId { get; set; }

        /// <summary>
        /// 结算对象mid来源
        /// </summary>
        [JsonPropertyName("sign_merchant_id_source")]
        public string SignMerchantIdSource { get; set; }

        /// <summary>
        /// 分析维度
        /// </summary>
        [JsonPropertyName("summary_dmsn_1")]
        public string SummaryDmsn1 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("summary_dmsn_2")]
        public string SummaryDmsn2 { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        [JsonPropertyName("summary_dmsn_3")]
        public string SummaryDmsn3 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("summary_dmsn_4")]
        public string SummaryDmsn4 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("summary_dmsn_5")]
        public string SummaryDmsn5 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("summary_dmsn_6")]
        public string SummaryDmsn6 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("summary_dmsn_7")]
        public string SummaryDmsn7 { get; set; }

        /// <summary>
        /// 汇总维度值
        /// </summary>
        [JsonPropertyName("summary_dmsn_value")]
        public string SummaryDmsnValue { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税种
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 未确认金额
        /// </summary>
        [JsonPropertyName("un_confirmed_amount")]
        public MultiCurrencyMoneyOpenApi UnConfirmedAmount { get; set; }

        /// <summary>
        /// 未回票金额 = (结算单==null ? 账单确认金额 ： 结算单可收票金额)-已回票金额
        /// </summary>
        [JsonPropertyName("un_invoice_amt")]
        public MultiCurrencyMoneyOpenApi UnInvoiceAmt { get; set; }

        /// <summary>
        /// 未结算金额= 账单确认金额-已结算金额
        /// </summary>
        [JsonPropertyName("un_settled_amount")]
        public MultiCurrencyMoneyOpenApi UnSettledAmount { get; set; }

        /// <summary>
        /// 数据版本标记
        /// </summary>
        [JsonPropertyName("version_flag")]
        public string VersionFlag { get; set; }
    }
}
