using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份安全业务场景信息
        /// </summary>
        [JsonProperty("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务信息
        /// </summary>
        [JsonProperty("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 身份安全业务初始化后生成的token
        /// </summary>
        [JsonProperty("token_id")]
        public string TokenId { get; set; }
    }
}
