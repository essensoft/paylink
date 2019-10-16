using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArMonthlyStatementBillOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ArMonthlyStatementBillOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 账单核算时区
        /// </summary>
        [JsonProperty("accounting_time_zone")]
        public string AccountingTimeZone { get; set; }

        /// <summary>
        /// 应收日期(yyyyMMdd)
        /// </summary>
        [JsonProperty("accrued_date")]
        public string AccruedDate { get; set; }

        /// <summary>
        /// 调整金额
        /// </summary>
        [JsonProperty("adjust_amt")]
        public MultiCurrencyMoneyOpenApi AdjustAmt { get; set; }

        /// <summary>
        /// 业务扩展分析维度，来自于分析、汇总维度 k1=v1$k2=v2$k3=v3*
        /// </summary>
        [JsonProperty("analysis_dmsn")]
        public string AnalysisDmsn { get; set; }

        /// <summary>
        /// 分析维度1
        /// </summary>
        [JsonProperty("analysis_dmsn_1")]
        public string AnalysisDmsn1 { get; set; }

        /// <summary>
        /// 分析维度2
        /// </summary>
        [JsonProperty("analysis_dmsn_2")]
        public string AnalysisDmsn2 { get; set; }

        /// <summary>
        /// 分析维度3
        /// </summary>
        [JsonProperty("analysis_dmsn_3")]
        public string AnalysisDmsn3 { get; set; }

        /// <summary>
        /// 分析维度4
        /// </summary>
        [JsonProperty("analysis_dmsn_4")]
        public string AnalysisDmsn4 { get; set; }

        /// <summary>
        /// 申请中开票金额
        /// </summary>
        [JsonProperty("applying_invoice_amt")]
        public MultiCurrencyMoneyOpenApi ApplyingInvoiceAmt { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonProperty("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 原始账单金额（对于月账单存在调整金额的情况，真实账单金额=原始账单金额+调整金额）
        /// </summary>
        [JsonProperty("bill_amt")]
        public MultiCurrencyMoneyOpenApi BillAmt { get; set; }

        /// <summary>
        /// 账单结束日期
        /// </summary>
        [JsonProperty("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单月
        /// </summary>
        [JsonProperty("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单编码
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单开始日期
        /// </summary>
        [JsonProperty("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 收费项编码
        /// </summary>
        [JsonProperty("charge_item_code")]
        public string ChargeItemCode { get; set; }

        /// <summary>
        /// 计费类型，名称见charge_type_name
        /// </summary>
        [JsonProperty("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 01:云在线计费 02:离线计费 03:老主站计收费 04:芝麻在线计收费 05:国际在线计收费 06:网商计费 07:应收收入计提 08:应收返点计提 09:国际离线计收费 10:线上生成账单
        /// </summary>
        [JsonProperty("charge_type_name")]
        public string ChargeTypeName { get; set; }

        /// <summary>
        /// 对账状态 01 账单生成 02 待确认出账 03 已出账 04 客户已对账 05 对账差异 06 部分出账
        /// </summary>
        [JsonProperty("check_state")]
        public string CheckState { get; set; }

        /// <summary>
        /// 计算依据
        /// </summary>
        [JsonProperty("clcn_basic_amt")]
        public long ClcnBasicAmt { get; set; }

        /// <summary>
        /// 01 交易金额 02 交易笔数 03 交易张数 04 资费依据扩展 05 其他
        /// </summary>
        [JsonProperty("clcn_basic_type")]
        public string ClcnBasicType { get; set; }

        /// <summary>
        /// 01 交易金额 02 交易笔数 03 交易张数 04 资费依据扩展 05 其他
        /// </summary>
        [JsonProperty("clcn_basic_type_name")]
        public string ClcnBasicTypeName { get; set; }

        /// <summary>
        /// 01 差额累进 02 全额累进 03 按传入金额收费 04 价格包量 05 包时间周期 06 按时间全额累进 07 包时间周期差额累进 08 期间差额累进 09 期间全额累进 10 包时间周期单笔 11 标准单笔计费 12 包时间周期单笔-按照传入金额计费 13 期间靠档差额累进 14 自定义
        /// </summary>
        [JsonProperty("clcn_method")]
        public string ClcnMethod { get; set; }

        /// <summary>
        /// 01 差额累进 02 全额累进 03 按传入金额收费 04 价格包量 05 包时间周期 06 按时间全额累进 07 包时间周期差额累进 08 期间差额累进 09 期间全额累进 10 包时间周期单笔 11 标准单笔计费 12 包时间周期单笔-按照传入金额计费 13 期间靠档差额累进 14 自定义
        /// </summary>
        [JsonProperty("clcn_method_name")]
        public string ClcnMethodName { get; set; }

        /// <summary>
        /// 调账金额
        /// </summary>
        [JsonProperty("detail_bill_adj_amt")]
        public MultiCurrencyMoneyOpenApi DetailBillAdjAmt { get; set; }

        /// <summary>
        /// 调账原因
        /// </summary>
        [JsonProperty("detail_bill_adj_reason")]
        public string DetailBillAdjReason { get; set; }

        /// <summary>
        /// 环境标识:租户ID
        /// </summary>
        [JsonProperty("env_source")]
        public string EnvSource { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonProperty("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 是否是关联交易
        /// </summary>
        [JsonProperty("inter_trade_flag")]
        public string InterTradeFlag { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [JsonProperty("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 发票单据状态 01 未开票 02 部分开票 03 完全开票 04 线下开票 09 作废
        /// </summary>
        [JsonProperty("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [JsonProperty("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 结算对象参与者标识
        /// </summary>
        [JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象参与者角色标识
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [JsonProperty("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 记录未开票原因
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 元数据来源标识，包括(用户、商户、产品、合约、计费)来源
        /// </summary>
        [JsonProperty("metadata_source")]
        public string MetadataSource { get; set; }

        /// <summary>
        /// 应收月账单号
        /// </summary>
        [JsonProperty("monthly_bill_no")]
        public string MonthlyBillNo { get; set; }

        /// <summary>
        /// 已付金额1
        /// </summary>
        [JsonProperty("paid_amt")]
        public MultiCurrencyMoneyOpenApi PaidAmt { get; set; }

        /// <summary>
        /// 是否存在往期扣款金额
        /// </summary>
        [JsonProperty("past_pay_flag")]
        public bool PastPayFlag { get; set; }

        /// <summary>
        /// 付款状态 01 待结算 02 部分结算 03 结算完
        /// </summary>
        [JsonProperty("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 付款方式 1资金  5走量
        /// </summary>
        [JsonProperty("pay_way")]
        public string PayWay { get; set; }

        /// <summary>
        /// 可付金额
        /// </summary>
        [JsonProperty("payable_amt")]
        public MultiCurrencyMoneyOpenApi PayableAmt { get; set; }

        /// <summary>
        /// 可付标记
        /// </summary>
        [JsonProperty("payable_flag")]
        public string PayableFlag { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [JsonProperty("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 付款方银行账号
        /// </summary>
        [JsonProperty("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 扣款对象pid
        /// </summary>
        [JsonProperty("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 政策id
        /// </summary>
        [JsonProperty("price_policy_id")]
        public string PricePolicyId { get; set; }

        /// <summary>
        /// 产品码，金融云为商品ID
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品名称，金融云为空，需要自己查询
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 已收金额
        /// </summary>
        [JsonProperty("received_amt")]
        public MultiCurrencyMoneyOpenApi ReceivedAmt { get; set; }

        /// <summary>
        /// 关联的可开票单据列表
        /// </summary>
        [JsonProperty("rel_rcpt_list")]
        public List<string> RelRcptList { get; set; }

        /// <summary>
        /// 结算周期 01 年结 02 季结 03 月结 99 其它结算周期
        /// </summary>
        [JsonProperty("settle_period")]
        public string SettlePeriod { get; set; }

        /// <summary>
        /// 账单结算时区
        /// </summary>
        [JsonProperty("settle_time_zone")]
        public string SettleTimeZone { get; set; }

        /// <summary>
        /// 01 实时 02 预收 03 后收 04 周期结算 05 按日结算 09 延期结算 12 新周期结算
        /// </summary>
        [JsonProperty("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 签约对象参与者标识
        /// </summary>
        [JsonProperty("sign_ip_id")]
        public string SignIpId { get; set; }

        /// <summary>
        /// 参与者名称,金融云需要自己查询
        /// </summary>
        [JsonProperty("sign_ip_id_name")]
        public string SignIpIdName { get; set; }

        /// <summary>
        /// 签约对象参与者角色标识
        /// </summary>
        [JsonProperty("sign_ip_role_id")]
        public string SignIpRoleId { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 02 营业税 01 增值税 00 无税
        /// </summary>
        [JsonProperty("tax_tp")]
        public string TaxTp { get; set; }

        /// <summary>
        /// 租户标识
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 待核销明细数量
        /// </summary>
        [JsonProperty("to_writeoff_detail_count")]
        public string ToWriteoffDetailCount { get; set; }

        /// <summary>
        /// 账单类型  1应收，2返点 ,4递延
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 账单类型  1应收，2返点，4递延
        /// </summary>
        [JsonProperty("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        /// 核销明细数量
        /// </summary>
        [JsonProperty("writeoff_detail_count")]
        public string WriteoffDetailCount { get; set; }
    }
}
