using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppFirstCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppFirstCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 旅行住宿
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 小程序类目名称
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 二级类目列表
        /// </summary>
        [JsonProperty("child_category")]
        public List<MiniAppSecondCategoryInfo> ChildCategory { get; set; }
    }
}
