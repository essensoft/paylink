using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtSettleinfoQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtSettleinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 账户名
        /// </summary>
        [JsonPropertyName("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 账户(脱敏)
        /// </summary>
        [JsonPropertyName("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 退票时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("dishonoured_time")]
        public string DishonouredTime { get; set; }

        /// <summary>
        /// 结算失败(退票)的原因码(结算失败或退票消息为必选字段)。  ACCOUNT_NOT_MATCH:银行校验账号和户名不一致；  ACCOUNT_DISABLED:银行账户不可用；  DEFAULT_MSG:处理延时，请等待，系统稍后将自动重试；
        /// </summary>
        [JsonPropertyName("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 结算失败(退票)的原因描述(结算失败或退票为必选)。  ACCOUNT_NOT_MATCH:银行校验账号和户名不一致；  ACCOUNT_DISABLED:银行账户不可用；  DEFAULT_MSG:处理延时，请等待，系统稍后将自动重试；
        /// </summary>
        [JsonPropertyName("fail_desc")]
        public string FailDesc { get; set; }

        /// <summary>
        /// 净结算金额，取值范围[0.01,100000000]，精确到小数点后2位。
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 净结算金额的币种
        /// </summary>
        [JsonPropertyName("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 支付宝结算单据号
        /// </summary>
        [JsonPropertyName("settle_id")]
        public string SettleId { get; set; }

        /// <summary>
        /// 本次结算对应的结算周期的起始时间（包含此时间点），格式为yyyy-MM-dd HH:mm:ss。 例如，若按天结算，日切点为0点时，某一笔的结算周期时间为： settle_period_begin_time = 2018-01-01 00:00:00 settle_period_end_time = 2018-01-02 00:00:00
        /// </summary>
        [JsonPropertyName("settle_period_begin_time")]
        public string SettlePeriodBeginTime { get; set; }

        /// <summary>
        /// 本次结算对应的结算周期的起始时间（不包含此时间点），格式为yyyy-MM-dd HH:mm:ss。 例如，若按天结算，日切点为0点时，某一笔的结算周期时间为： settle_period_begin_time = 2018-01-01 00:00:00 settle_period_end_time = 2018-01-02 00:00:00
        /// </summary>
        [JsonPropertyName("settle_period_end_time")]
        public string SettlePeriodEndTime { get; set; }

        /// <summary>
        /// 结算成功时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 结算状态 0 成功 1 失败 2 退票
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
