using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BankInfo Data Structure.
    /// </summary>
    public class BankInfo : AlipayObject
    {
        /// <summary>
        /// 用户交易账号的发卡机构id
        /// </summary>
        [JsonPropertyName("account_issue_entity_id")]
        public string AccountIssueEntityId { get; set; }

        /// <summary>
        /// 用户交易账号的发卡机构名称
        /// </summary>
        [JsonPropertyName("account_issue_entity_name")]
        public string AccountIssueEntityName { get; set; }

        /// <summary>
        /// 用户在支付机构的开户名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 用户在支付机构的账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 机构联行号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }
    }
}
