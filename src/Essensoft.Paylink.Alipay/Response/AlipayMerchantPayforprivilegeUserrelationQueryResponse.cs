using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠业务用户与商户的关系
        /// </summary>
        [JsonPropertyName("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
