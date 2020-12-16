using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstAccountDTO Data Structure.
    /// </summary>
    public class InstAccountDTO : AlipayObject
    {
        /// <summary>
        /// 账户名称，account_type取值BANK_CARD时必填
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 支付宝账号，和account_type联合唯一
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型，和account_no联合唯一； 枚举值：BANK_CARD,BALANCE_ACCOUNT； 支付宝账户选择BALANCE_ACCOUNT，银行卡选择BANK_CARD。
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行联行号，account_type取值BANK_CARD时必填
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonPropertyName("biz_param")]
        public string BizParam { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 账户的OU信息，根据实际情况填写
        /// </summary>
        [JsonPropertyName("org_unit")]
        public string OrgUnit { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
