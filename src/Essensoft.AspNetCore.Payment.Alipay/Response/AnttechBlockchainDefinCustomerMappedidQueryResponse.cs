using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMappedidQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMappedidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员信息
        /// </summary>
        [JsonPropertyName("user_info_list")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
