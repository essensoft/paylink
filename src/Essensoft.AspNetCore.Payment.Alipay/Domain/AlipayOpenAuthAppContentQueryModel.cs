using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }
    }
}
