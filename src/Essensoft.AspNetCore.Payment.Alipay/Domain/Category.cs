using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Category Data Structure.
    /// </summary>
    [Serializable]
    public class Category : AlipayObject
    {
        /// <summary>
        /// 店铺分类ID集合
        /// </summary>
        [JsonProperty("shop_cate_ids")]
        public List<string> ShopCateIds { get; set; }

        /// <summary>
        /// 美食/娱乐等分类条目
        /// </summary>
        [JsonProperty("shop_cate_name")]
        public string ShopCateName { get; set; }
    }
}
