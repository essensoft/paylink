using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionBankAccountDetail Data Structure.
    /// </summary>
    public class TuitionBankAccountDetail : AlipayObject
    {
        /// <summary>
        /// 银行收款账号
        /// </summary>
        [JsonPropertyName("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 银行swiftCode/BIC
        /// </summary>
        [JsonPropertyName("bank_bic")]
        public string BankBic { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行收款账户名
        /// </summary>
        [JsonPropertyName("holder_account_name")]
        public TuitionUserName HolderAccountName { get; set; }

        /// <summary>
        /// 银行收款账户地址
        /// </summary>
        [JsonPropertyName("holder_address")]
        public TuitionAddress HolderAddress { get; set; }

        /// <summary>
        /// 本地银行清算号
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
