using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
