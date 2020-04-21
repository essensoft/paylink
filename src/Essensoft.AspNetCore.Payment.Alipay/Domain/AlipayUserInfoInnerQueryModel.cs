using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInfoInnerQueryModel Data Structure.
    /// </summary>
    public class AlipayUserInfoInnerQueryModel : AlipayObject
    {
        /// <summary>
        /// 阿里集团统一ID
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
