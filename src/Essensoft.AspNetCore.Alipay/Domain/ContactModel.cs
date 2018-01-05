using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ContactModel Data Structure.
    /// </summary>
    public class ContactModel : AlipayObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }
    }
}
