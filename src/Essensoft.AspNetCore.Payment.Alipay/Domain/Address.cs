using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Address Data Structure.
    /// </summary>
    public class Address : AlipayObject
    {
        /// <summary>
        /// city，市名
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// county，用于区、县的描述
        /// </summary>
        [JsonPropertyName("county")]
        public string County { get; set; }

        /// <summary>
        /// detail，地址详情
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// province，省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
