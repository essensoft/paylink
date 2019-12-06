using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArMonthlyBillDTO Data Structure.
    /// </summary>
    public class ArMonthlyBillDTO : AlipayObject
    {
        /// <summary>
        /// 出账日
        /// </summary>
        [JsonPropertyName("account_day")]
        public string AccountDay { get; set; }

        /// <summary>
        /// 应收日期(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("accrued_date")]
        public string AccruedDate { get; set; }

        /// <summary>
        /// 调账金额
        /// </summary>
        [JsonPropertyName("adjust_amt")]
        public MultiCurrencyMoneyOpenApi AdjustAmt { get; set; }

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
        /// 合约号，商户签约产品对应的合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单金额（原始账单金额，对于月账单存在调整金额的情况，真实账单金额=原始账单金额+调整金额）
        /// </summary>
        [JsonPropertyName("bill_amt")]
        public MultiCurrencyMoneyOpenApi BillAmt { get; set; }

        /// <summary>
        /// 账单结束日期
        /// </summary>
        [JsonPropertyName("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单月
        /// </summary>
        [JsonPropertyName("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 月账单号,唯一标识月账单的ID
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单开始日期
        /// </summary>
        [JsonPropertyName("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 账单类型  21：应收月账单  目前仅支持该类型的账单类型
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 收费项编码
        /// </summary>
        [JsonPropertyName("charge_item_code")]
        public string ChargeItemCode { get; set; }

        /// <summary>
        /// 计费类型  01：云在线计费，02：离线计费，03：老主站计收费，04：芝麻在线计收费
        /// </summary>
        [JsonPropertyName("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 出账状态  01：账单生成，02：待确认出账，03：已出账，04：客户已对账，05：对账差异，06：部分出账
        /// </summary>
        [JsonPropertyName("check_status")]
        public string CheckStatus { get; set; }

        /// <summary>
        /// 已出账金额
        /// </summary>
        [JsonPropertyName("checked_amt")]
        public MultiCurrencyMoneyOpenApi CheckedAmt { get; set; }

        /// <summary>
        /// 出账中金额
        /// </summary>
        [JsonPropertyName("checking_amt")]
        public MultiCurrencyMoneyOpenApi CheckingAmt { get; set; }

        /// <summary>
        /// 计算依据
        /// </summary>
        [JsonPropertyName("clcn_basic_amt")]
        public long ClcnBasicAmt { get; set; }

        /// <summary>
        /// 计算依据类型  01：交易金额，02：交易笔数，03：交易张数，04：资费依据扩展，05：其他
        /// </summary>
        [JsonPropertyName("clcn_basic_type")]
        public string ClcnBasicType { get; set; }

        /// <summary>
        /// 计算方法  01：差额累进，02：全额累进，03：按传入金额收费，04：价格包量，05：包时间周期，06：按时间全额累进，07：包时间周期差额累进，08：期间差额累进，09：期间全额累进，10：包时间周期单笔，11：标准单笔计费，12：包时间周期单笔-按照传入金额计费，13：期间靠档差额累进，靠档计息使用，14：自定义
        /// </summary>
        [JsonPropertyName("clcn_method")]
        public string ClcnMethod { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonPropertyName("freeze_amt")]
        public MultiCurrencyMoneyOpenApi FreezeAmt { get; set; }

        /// <summary>
        /// 创建时间（创建备份时需要）
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间（创建备份时需要）
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 分支机构号
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [JsonPropertyName("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 结算对象参与者标识
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 参与者名字
        /// </summary>
        [JsonPropertyName("ip_name")]
        public string IpName { get; set; }

        /// <summary>
        /// 结算对象参与者角色标识
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonPropertyName("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [JsonPropertyName("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 付款来源  1：主账务，2：包量，3：预收，4：预存，5：银行，6：积分，7：统一支付，8：支付受理
        /// </summary>
        [JsonPropertyName("pay_original")]
        public string PayOriginal { get; set; }

        /// <summary>
        /// 付款状态  01：待结算；02：部分结算；03：结算完成
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 付款方式  1：资金；2：包量
        /// </summary>
        [JsonPropertyName("pay_way")]
        public string PayWay { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [JsonPropertyName("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [JsonPropertyName("payer_account")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// 扣款对象pid
        /// </summary>
        [JsonPropertyName("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 已收金额
        /// </summary>
        [JsonPropertyName("received_amt")]
        public MultiCurrencyMoneyOpenApi ReceivedAmt { get; set; }

        /// <summary>
        /// 记录id，账单全局唯一号
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 服务金额
        /// </summary>
        [JsonPropertyName("service_amt")]
        public MultiCurrencyMoneyOpenApi ServiceAmt { get; set; }

        /// <summary>
        /// 结算类型  01：实时；02：预收；03：后收；04：周期结算；05：按日汇总结算；09：延期结算
        /// </summary>
        [JsonPropertyName("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 签约对象参与者标识
        /// </summary>
        [JsonPropertyName("sign_ip_id")]
        public string SignIpId { get; set; }

        /// <summary>
        /// 签约对象参与者角色标识
        /// </summary>
        [JsonPropertyName("sign_ip_role_id")]
        public string SignIpRoleId { get; set; }

        /// <summary>
        /// 结算对象PID
        /// </summary>
        [JsonPropertyName("stl_ip_role_id")]
        public string StlIpRoleId { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 税收类型，01：增值税，02：营业税  营业税已经在大部分行业废弃，要传入需咨询后再确认
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 待核销明细数量
        /// </summary>
        [JsonPropertyName("to_writeoff_detail_count")]
        public long ToWriteoffDetailCount { get; set; }

        /// <summary>
        /// 账单分类 1应收，2返点
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 核销明细数量
        /// </summary>
        [JsonPropertyName("writeoff_detail_dount")]
        public long WriteoffDetailDount { get; set; }

        /// <summary>
        /// 核销中金额
        /// </summary>
        [JsonPropertyName("writingoff_amt")]
        public MultiCurrencyMoneyOpenApi WritingoffAmt { get; set; }
    }
}
