using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppFirstCategoryInfo Data Structure.
    /// </summary>
    public class MiniAppFirstCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 旅行住宿
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 小程序类目名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 二级类目列表
        /// </summary>
        [JsonPropertyName("child_category")]
        public List<MiniAppSecondCategoryInfo> ChildCategory { get; set; }
    }
}
