using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferAddressInfo Data Structure.
    /// </summary>
    public class TransferAddressInfo : AlipayObject
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
        /// 地市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 两位国家编码
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// 州/省份
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
