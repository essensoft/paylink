using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserIdentityExt Data Structure.
    /// </summary>
    public class UserIdentityExt : AlipayObject
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
        /// 扩展参数。JSON格式，使用前需要和支付宝先约定key值。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户在商家平台的会员id
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 用户在商家平台的会员名称
        /// </summary>
        [JsonPropertyName("member_name")]
        public string MemberName { get; set; }
    }
}
