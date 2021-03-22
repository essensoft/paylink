using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JointAccountMemberList Data Structure.
    /// </summary>
    public class JointAccountMemberList : AlipayObject
    {
        /// <summary>
        /// 额度模型
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
