using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncApbillTotalbillamtQueryResponse.
    /// </summary>
    public class AlipayBossFncApbillTotalbillamtQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇总调整金额
        /// </summary>
        [JsonPropertyName("agr_adj_amt")]
        public MultiCurrencyMoneyOpenApi AgrAdjAmt { get; set; }

        /// <summary>
        /// 确认汇总调整金额
        /// </summary>
        [JsonPropertyName("agr_adj_chk_amt")]
        public MultiCurrencyMoneyOpenApi AgrAdjChkAmt { get; set; }

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
        /// 原始账单金额
        /// </summary>
        [JsonPropertyName("bill_amt")]
        public MultiCurrencyMoneyOpenApi BillAmt { get; set; }

        /// <summary>
        /// 账单对账状态{"01":"账单生成","02":"待确认出账","03":"已出账","04":"客户已对账","05":"对账差异","06":"部分出账","07":"账单出账中"}
        /// </summary>
        [JsonPropertyName("bill_check_status")]
        public string BillCheckStatus { get; set; }

        /// <summary>
        /// 原始账单确认金额
        /// </summary>
        [JsonPropertyName("bill_chk_amt")]
        public MultiCurrencyMoneyOpenApi BillChkAmt { get; set; }

        /// <summary>
        /// 账单结束日期yyyyMMdd
        /// </summary>
        [JsonPropertyName("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单关联发票状态{"01":"未关联","02':"部分关联","03":"完全关联"}
        /// </summary>
        [JsonPropertyName("bill_invoice_link_status")]
        public string BillInvoiceLinkStatus { get; set; }

        /// <summary>
        /// 账单月(yyyyMM)
        /// </summary>
        [JsonPropertyName("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单开始日期yyyyMMdd
        /// </summary>
        [JsonPropertyName("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 明细调整金额
        /// </summary>
        [JsonPropertyName("dtl_adj_amt")]
        public MultiCurrencyMoneyOpenApi DtlAdjAmt { get; set; }

        /// <summary>
        /// 确认明细调整金额
        /// </summary>
        [JsonPropertyName("dtl_adj_chk_amt")]
        public MultiCurrencyMoneyOpenApi DtlAdjChkAmt { get; set; }

        /// <summary>
        /// 账单结束日期(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 月账单扩展字段
        /// </summary>
        [JsonPropertyName("exn_inf")]
        public string ExnInf { get; set; }

        /// <summary>
        /// 止付金额
        /// </summary>
        [JsonPropertyName("fbd_pay_amt")]
        public MultiCurrencyMoneyOpenApi FbdPayAmt { get; set; }

        /// <summary>
        /// 确认止付金额
        /// </summary>
        [JsonPropertyName("fbd_pay_chk_amt")]
        public MultiCurrencyMoneyOpenApi FbdPayChkAmt { get; set; }

        /// <summary>
        /// 分支机构ID（OU标识）
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 在途金额
        /// </summary>
        [JsonPropertyName("intransit_amt")]
        public MultiCurrencyMoneyOpenApi IntransitAmt { get; set; }

        /// <summary>
        /// 关联发票金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 结算对象（PID）
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// MID
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 税损扣除后月账单可关联发票金额
        /// </summary>
        [JsonPropertyName("new_can_invoice_amt")]
        public MultiCurrencyMoneyOpenApi NewCanInvoiceAmt { get; set; }

        /// <summary>
        /// 已付金额
        /// </summary>
        [JsonPropertyName("paid_amt")]
        public MultiCurrencyMoneyOpenApi PaidAmt { get; set; }

        /// <summary>
        /// 付款渠道[银行账号/支付宝账号/国际银行卡]
        /// </summary>
        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 付款状态{"01":"待结算","02":"部分结算","03":"结算完成"}
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
        /// 预付已冲销金额
        /// </summary>
        [JsonPropertyName("pre_wrtof_amt")]
        public MultiCurrencyMoneyOpenApi PreWrtofAmt { get; set; }

        /// <summary>
        /// 价格标识
        /// </summary>
        [JsonPropertyName("price_id")]
        public string PriceId { get; set; }

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
        /// 账单金额
        /// </summary>
        [JsonPropertyName("real_bill_amt")]
        public MultiCurrencyMoneyOpenApi RealBillAmt { get; set; }

        /// <summary>
        /// 确认账单金额
        /// </summary>
        [JsonPropertyName("real_bill_chk_amt")]
        public MultiCurrencyMoneyOpenApi RealBillChkAmt { get; set; }

        /// <summary>
        /// 结算类型，暂不提供枚举，01-实时，02-后付，03-周期性
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

        /// <summary>
        /// 含税金额（账单金额 + 代缴税金金额）
        /// </summary>
        [JsonPropertyName("tax_included_amt")]
        public MultiCurrencyMoneyOpenApi TaxIncludedAmt { get; set; }

        /// <summary>
        /// 代缴税金金额
        /// </summary>
        [JsonPropertyName("withhold_tax_amt")]
        public MultiCurrencyMoneyOpenApi WithholdTaxAmt { get; set; }

        /// <summary>
        /// 确认代缴税金金额
        /// </summary>
        [JsonPropertyName("withhold_tax_chk_amt")]
        public MultiCurrencyMoneyOpenApi WithholdTaxChkAmt { get; set; }
    }
}
