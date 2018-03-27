using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IdentityParam Data Structure.
    /// </summary>
    public class IdentityParam : AlipayObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 身份类型
        /// </summary>
        [JsonProperty("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
