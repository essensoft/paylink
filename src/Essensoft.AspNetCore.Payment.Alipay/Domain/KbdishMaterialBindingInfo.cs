using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishMaterialBindingInfo Data Structure.
    /// </summary>
    public class KbdishMaterialBindingInfo : AlipayObject
    {
        /// <summary>
        /// 加料id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 菜品加料排序字段，从1开始递增
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
