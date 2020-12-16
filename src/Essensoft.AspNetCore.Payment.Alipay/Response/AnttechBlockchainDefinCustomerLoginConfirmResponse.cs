using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerLoginConfirmResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerLoginConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user_info")]
        public DefiCustUserDTO UserInfo { get; set; }
    }
}
