using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
