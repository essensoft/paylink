using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerUserQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user_info_list")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
