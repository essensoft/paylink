using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberCreateResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 中台会员唯一ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }
    }
}
