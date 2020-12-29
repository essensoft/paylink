using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员对象
        /// </summary>
        [JsonPropertyName("member_info_list")]
        public List<DefiCustMemberDTO> MemberInfoList { get; set; }
    }
}
