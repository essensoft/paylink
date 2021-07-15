using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantMrchsurpActivitysignupCreateModel Data Structure.
    /// </summary>
    public class AlipayMerchantMrchsurpActivitysignupCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 用户在客户端操作的umidToken，用户安全风控的校验
        /// </summary>
        [JsonPropertyName("umid_token")]
        public string UmidToken { get; set; }

        /// <summary>
        /// 报名活动的用户ID，蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
