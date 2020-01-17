using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceBankAccountInfo Data Structure.
    /// </summary>
    public class FinanceBankAccountInfo : AlipayObject
    {
        /// <summary>
        /// 银行账户名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 银行账户号码
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 开户银行地址
        /// </summary>
        [JsonPropertyName("bank_address")]
        public string BankAddress { get; set; }

        /// <summary>
        /// 开户市
        /// </summary>
        [JsonPropertyName("bank_city")]
        public string BankCity { get; set; }

        /// <summary>
        /// 开户银行编码
        /// </summary>
        [JsonPropertyName("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 开户省
        /// </summary>
        [JsonPropertyName("bank_province")]
        public string BankProvince { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [JsonPropertyName("branch_id")]
        public string BranchId { get; set; }

        /// <summary>
        /// 开户支行
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// swift code
        /// </summary>
        [JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
