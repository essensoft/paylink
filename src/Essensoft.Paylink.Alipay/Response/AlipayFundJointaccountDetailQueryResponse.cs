using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountDetailQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业设置的共同账户的别名
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 额度模型
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

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
