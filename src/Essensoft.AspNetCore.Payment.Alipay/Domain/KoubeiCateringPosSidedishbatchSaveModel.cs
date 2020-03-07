using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosSidedishbatchSaveModel : AlipayObject
    {
        /// <summary>
        /// 需要添加配菜的菜品ID
        /// </summary>
        [JsonPropertyName("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 批量添加的配菜
        /// </summary>
        [JsonPropertyName("dish_material_list")]
        public List<PosDishMaterialModel> DishMaterialList { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
