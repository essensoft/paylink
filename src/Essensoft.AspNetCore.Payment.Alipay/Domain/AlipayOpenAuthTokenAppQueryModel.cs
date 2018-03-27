using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthTokenAppQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [JsonProperty("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
