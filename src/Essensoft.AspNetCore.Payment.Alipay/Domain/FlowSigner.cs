using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FlowSigner Data Structure.
    /// </summary>
    public class FlowSigner : AlipayObject
    {
        /// <summary>
        /// 创建流程时指定的企业唯一标识，仅签署主体为企业时返回
        /// </summary>
        [JsonPropertyName("org_third_party_user_id")]
        public string OrgThirdPartyUserId { get; set; }

        /// <summary>
        /// 签署状态：0-待签, 1-未签, 2-已签 3-待审批 4-拒签
        /// </summary>
        [JsonPropertyName("sign_status")]
        public long SignStatus { get; set; }

        /// <summary>
        /// 签署主体类型：0-个人, 1-企业
        /// </summary>
        [JsonPropertyName("signer_account_type")]
        public long SignerAccountType { get; set; }

        /// <summary>
        /// 创建流程时指定个人唯一标识
        /// </summary>
        [JsonPropertyName("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
