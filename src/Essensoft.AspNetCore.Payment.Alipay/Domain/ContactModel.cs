using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContactModel Data Structure.
    /// </summary>
    public class ContactModel : AlipayObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }
    }
}
