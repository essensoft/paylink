using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 要绑定的标签Id
        /// </summary>
        [JsonPropertyName("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头长度为16位的字符串
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
