using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishVirtualDishSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishVirtualDishSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 菜品在虚拟类目中的排序值，只支持数字类型，如果不填默认1
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
