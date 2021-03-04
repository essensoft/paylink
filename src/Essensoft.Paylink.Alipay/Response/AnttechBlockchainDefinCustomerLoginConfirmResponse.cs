using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
