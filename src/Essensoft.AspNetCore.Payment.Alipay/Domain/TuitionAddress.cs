using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionAddress Data Structure.
    /// </summary>
    public class TuitionAddress : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City or District or Suburb or Town or Village
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// State or County or Province
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
    }
}
