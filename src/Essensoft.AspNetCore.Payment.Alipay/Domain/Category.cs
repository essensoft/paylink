using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Category Data Structure.
    /// </summary>
    public class Category : AlipayObject
    {
        /// <summary>
        /// 店铺分类ID集合
        /// </summary>
        [JsonPropertyName("shop_cate_ids")]
        public List<string> ShopCateIds { get; set; }

        /// <summary>
        /// 美食/娱乐等分类条目
        /// </summary>
        [JsonPropertyName("shop_cate_name")]
        public string ShopCateName { get; set; }
    }
}
