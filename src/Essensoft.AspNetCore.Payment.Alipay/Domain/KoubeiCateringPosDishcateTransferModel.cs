using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishcateTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishcateTransferModel : AlipayObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonProperty("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品ID列表
        /// </summary>
        [JsonProperty("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
