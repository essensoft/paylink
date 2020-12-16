using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperationAddress Data Structure.
    /// </summary>
    public class OperationAddress : AlipayObject
    {
        /// <summary>
        /// 营业地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
    }
}
