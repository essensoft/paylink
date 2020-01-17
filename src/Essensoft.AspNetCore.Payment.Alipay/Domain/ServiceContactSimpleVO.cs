using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceContactSimpleVO Data Structure.
    /// </summary>
    public class ServiceContactSimpleVO : AlipayObject
    {
        /// <summary>
        /// 服务联系人邮箱
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 服务联系人名称
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 服务联系人电话
        /// </summary>
        [JsonPropertyName("contact_tele")]
        public string ContactTele { get; set; }
    }
}
