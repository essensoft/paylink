using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstAllocationQuotaVO Data Structure.
    /// </summary>
    public class InstAllocationQuotaVO : AlipayObject
    {
        /// <summary>
        /// 管控账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// BANK_CARD/BALANCE_ACCOUNT，银行卡/余额户
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 额度限制是否激活
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 额度配置附言
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// OUT/IN，流出限额/流入限额
        /// </summary>
        [JsonPropertyName("quota_mode")]
        public string QuotaMode { get; set; }

        /// <summary>
        /// 额度金额，默认人民币币种
        /// </summary>
        [JsonPropertyName("quota_value")]
        public string QuotaValue { get; set; }
    }
}
