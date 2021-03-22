using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundJointaccountRuleModifyModel Data Structure.
    /// </summary>
    public class AlipayFundJointaccountRuleModifyModel : AlipayObject
    {
        /// <summary>
        /// 账本ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账本名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户额度
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 交易授权信息 指定收单商户
        /// </summary>
        [JsonPropertyName("authorized_rule")]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
