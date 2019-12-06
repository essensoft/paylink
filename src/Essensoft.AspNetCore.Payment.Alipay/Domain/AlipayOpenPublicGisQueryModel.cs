using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGisQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGisQueryModel : AlipayObject
    {
        /// <summary>
        /// 该用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
