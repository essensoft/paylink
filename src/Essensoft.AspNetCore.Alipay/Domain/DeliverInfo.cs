using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// DeliverInfo Data Structure.
    /// </summary>
    public class DeliverInfo : AlipayObject
    {
        /// <summary>
        /// 保单寄送地址的住址
        /// </summary>
        [JsonProperty("recipients_address")]
        public string RecipientsAddress { get; set; }

        /// <summary>
        /// 配送地址行政区划代码
        /// </summary>
        [JsonProperty("recipients_address_code")]
        public string RecipientsAddressCode { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonProperty("recipients_name")]
        public string RecipientsName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonProperty("recipients_phone")]
        public string RecipientsPhone { get; set; }
    }
}
