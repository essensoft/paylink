using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝用户号，2088开头。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
