using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceContactInfo Data Structure.
    /// </summary>
    public class InvoiceContactInfo : AlipayObject
    {
        /// <summary>
        /// 联系人地址
        /// </summary>
        [JsonPropertyName("contact_addr")]
        public string ContactAddr { get; set; }

        /// <summary>
        /// 联系人邮件
        /// </summary>
        [JsonPropertyName("contact_mail")]
        public string ContactMail { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }
    }
}
