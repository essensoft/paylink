using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrincipalForOpenapi Data Structure.
    /// </summary>
    public class PrincipalForOpenapi : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }
    }
}
