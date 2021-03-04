using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishMaterialModifyModel : AlipayObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
