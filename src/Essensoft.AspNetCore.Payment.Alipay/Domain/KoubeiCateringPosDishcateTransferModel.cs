using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishcateTransferModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishcateTransferModel : AlipayObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品ID列表
        /// </summary>
        [JsonPropertyName("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
