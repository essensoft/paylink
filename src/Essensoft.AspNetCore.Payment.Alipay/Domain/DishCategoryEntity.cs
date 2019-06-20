using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishCategoryEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DishCategoryEntity : AlipayObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonProperty("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }
    }
}
