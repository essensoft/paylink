using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountInstfundWithdrawApplyModel Data Structure.
    /// </summary>
    public class AlipayAccountInstfundWithdrawApplyModel : AlipayObject
    {
        /// <summary>
        /// 提现卡户名
        /// </summary>
        [JsonPropertyName("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 提现卡号
        /// </summary>
        [JsonPropertyName("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 提现银行联行号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 付款账号
        /// </summary>
        [JsonPropertyName("debit_account_no")]
        public string DebitAccountNo { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [JsonPropertyName("debit_amount")]
        public string DebitAmount { get; set; }

        /// <summary>
        /// 付款币种
        /// </summary>
        [JsonPropertyName("debit_currency")]
        public string DebitCurrency { get; set; }

        /// <summary>
        /// 付款账号用户id
        /// </summary>
        [JsonPropertyName("debit_user_id")]
        public string DebitUserId { get; set; }

        /// <summary>
        /// 附言字段
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部序列号，联合PID，幂等使用
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
