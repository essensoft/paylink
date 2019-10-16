using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShieldDishList Data Structure.
    /// </summary>
    [Serializable]
    public class ShieldDishList : AlipayObject
    {
        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }

        /// <summary>
        /// 菜品下细分的sku ID
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
