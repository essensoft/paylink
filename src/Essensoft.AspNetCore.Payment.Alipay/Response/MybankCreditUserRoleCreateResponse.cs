using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditUserRoleCreateResponse.
    /// </summary>
    public class MybankCreditUserRoleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 参与者
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 参与者会员角色号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
