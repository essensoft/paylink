using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠业务用户与商户关系
        /// </summary>
        [JsonPropertyName("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
