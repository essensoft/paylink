using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountQuotaQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountQuotaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 共同账户额度模型
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员ID（如果查询员工才返回）
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
