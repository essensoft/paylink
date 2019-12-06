using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPartnerMenuQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPartnerMenuQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务窗id
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
