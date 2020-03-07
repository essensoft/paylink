using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialCreateResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
