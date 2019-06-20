using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目层级
        /// </summary>
        [JsonProperty("category_level")]
        public long CategoryLevel { get; set; }
    }
}
