using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniBizdataTemplatemessageDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniBizdataTemplatemessageDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商户业务流水id，应该是商户侧数据的唯一键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
