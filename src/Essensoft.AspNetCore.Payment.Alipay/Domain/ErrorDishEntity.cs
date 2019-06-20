using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ErrorDishEntity Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorDishEntity : AlipayObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }
    }
}
