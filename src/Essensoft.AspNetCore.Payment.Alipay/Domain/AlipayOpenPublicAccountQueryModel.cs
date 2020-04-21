using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号userid，2088开头长度为16位的字符串
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
