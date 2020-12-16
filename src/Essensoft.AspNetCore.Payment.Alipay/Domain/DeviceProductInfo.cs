using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceProductInfo Data Structure.
    /// </summary>
    public class DeviceProductInfo : AlipayObject
    {
        /// <summary>
        /// 产品id
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }
    }
}
