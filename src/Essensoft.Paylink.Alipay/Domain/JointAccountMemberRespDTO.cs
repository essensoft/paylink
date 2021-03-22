using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JointAccountMemberRespDTO Data Structure.
    /// </summary>
    public class JointAccountMemberRespDTO : AlipayObject
    {
        /// <summary>
        /// 额度模型
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员支付宝登录号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 员工当前状态：  邀请中（PROCESSING）、正常（NORMAL）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝会员号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
