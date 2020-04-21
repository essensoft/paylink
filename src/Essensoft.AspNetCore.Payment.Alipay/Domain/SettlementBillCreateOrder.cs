using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettlementBillCreateOrder Data Structure.
    /// </summary>
    public class SettlementBillCreateOrder : AlipayObject
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 合约体系： IARCORE - ipay合约中心 MYBKARCORE - 网商产品中心 ARCORE - 主站合约 中心 OTHER - 其他合约中心
        /// </summary>
        [JsonPropertyName("ar_source")]
        public string ArSource { get; set; }

        /// <summary>
        /// 结算周期 DAILY  -按日 TEN_DAY - 旬结 WEEKLY-周结 MOTHLY-月结 QUARTERLY - 旬结 HALF_YEAR - 半年结 YEARLY - 年结 BIENNIALLY - 两年结
        /// </summary>
        [JsonPropertyName("business_period")]
        public string BusinessPeriod { get; set; }

        /// <summary>
        /// 结算周期偏移 单位为天      如某业务月结，但结算周期是从 某月5号到下一月5号，则此时此处填写5 表示5天偏移量
        /// </summary>
        [JsonPropertyName("business_period_offset")]
        public long BusinessPeriodOffset { get; set; }

        /// <summary>
        /// 业务扩展类型 当前大量的业务系统采取复用产品码的方案，需要额外的业务识别才能够明确业务
        /// </summary>
        [JsonPropertyName("business_recognize_ext")]
        public MapParameter BusinessRecognizeExt { get; set; }

        /// <summary>
        /// 扩展信息透传
        /// </summary>
        [JsonPropertyName("exn_info")]
        public MapParameter ExnInfo { get; set; }

        /// <summary>
        /// 我方ou缩写
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 结算对象pid。用于标明向谁开票、对账
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 外部业务单据号。此单号会用于幂等
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [JsonPropertyName("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 账号的类型  BANK-银行 ALIPAY-支付宝 MYBANK-网商银行
        /// </summary>
        [JsonPropertyName("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [JsonPropertyName("payer_account")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// 账号的类型 参考payeeaccounttype
        /// </summary>
        [JsonPropertyName("payer_account_type")]
        public string PayerAccountType { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品体系： IPTCORE -ipay产品中心 MYBKPTCORE - 网商产品中心 PTCORE - 主站产品中心 AFC - 金融云产品中心
        /// </summary>
        [JsonPropertyName("pd_source")]
        public string PdSource { get; set; }

        /// <summary>
        /// 业务开始时间
        /// </summary>
        [JsonPropertyName("service_begin_date")]
        public string ServiceBeginDate { get; set; }

        /// <summary>
        /// 业务结束时间
        /// </summary>
        [JsonPropertyName("service_end_date")]
        public string ServiceEndDate { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public MultiCurrencyMoneyOpenApi SettleAmount { get; set; }

        /// <summary>
        /// 结算依据
        /// </summary>
        [JsonPropertyName("settle_basis")]
        public long SettleBasis { get; set; }

        /// <summary>
        /// 收费费率
        /// </summary>
        [JsonPropertyName("settle_rate")]
        public long SettleRate { get; set; }

        /// <summary>
        /// CONTRACT - 合同 TRADING_AMOUNT - 交易金额 TRADING_QUANTITY - 交易笔数
        /// </summary>
        [JsonPropertyName("settlement_basic_type")]
        public string SettlementBasicType { get; set; }

        /// <summary>
        /// REAL_TIME-实时 DELAYED -后收
        /// </summary>
        [JsonPropertyName("settlement_type")]
        public string SettlementType { get; set; }

        /// <summary>
        /// 签约对象-用于标明谁跟我们签约
        /// </summary>
        [JsonPropertyName("sign_ip_role_id")]
        public string SignIpRoleId { get; set; }

        /// <summary>
        /// 调用方系统名称
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 时区。 国内业务都是东8区（北京时间） UTC+08:00
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 用户体系： ICIF - ipay用户体系 MYBKCIF - 网商银行用户体系 CIF - 主站用户体系 UC - 金融云用户体系
        /// </summary>
        [JsonPropertyName("user_source")]
        public string UserSource { get; set; }
    }
}
