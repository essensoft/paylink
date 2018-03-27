using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryAddress Data Structure.
    /// </summary>
    public class AssetDeliveryAddress : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 区信息
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }
}
