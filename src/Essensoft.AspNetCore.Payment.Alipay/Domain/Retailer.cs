using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Retailer Data Structure.
    /// </summary>
    public class Retailer : AlipayObject
    {
        /// <summary>
        /// 零售商名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 零售商pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
