using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdUserMatchModel : AlipayObject
    {
        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [JsonPropertyName("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
