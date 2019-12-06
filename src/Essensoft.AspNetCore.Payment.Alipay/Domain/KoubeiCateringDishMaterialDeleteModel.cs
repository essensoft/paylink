using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishMaterialDeleteModel : AlipayObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
