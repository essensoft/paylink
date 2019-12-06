using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliverInfo Data Structure.
    /// </summary>
    public class DeliverInfo : AlipayObject
    {
        /// <summary>
        /// 保单寄送地址的住址
        /// </summary>
        [JsonPropertyName("recipients_address")]
        public string RecipientsAddress { get; set; }

        /// <summary>
        /// 配送地址行政区划代码
        /// </summary>
        [JsonPropertyName("recipients_address_code")]
        public string RecipientsAddressCode { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonPropertyName("recipients_name")]
        public string RecipientsName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonPropertyName("recipients_phone")]
        public string RecipientsPhone { get; set; }
    }
}
