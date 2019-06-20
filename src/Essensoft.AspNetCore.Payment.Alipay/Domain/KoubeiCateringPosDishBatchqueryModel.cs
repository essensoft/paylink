using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 菜谱的ID
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 按照菜品名字模糊查询菜谱下的菜品
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
