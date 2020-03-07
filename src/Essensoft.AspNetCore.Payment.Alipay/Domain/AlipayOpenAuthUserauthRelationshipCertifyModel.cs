using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipCertifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationshipCertifyModel : AlipayObject
    {
        /// <summary>
        /// 操作接口名字
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
