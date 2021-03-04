using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelUserQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户的userid，2088开头长度为16位的字符串
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
