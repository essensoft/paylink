using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialEntity Data Structure.
    /// </summary>
    public class MaterialEntity : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [JsonPropertyName("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }
    }
}
