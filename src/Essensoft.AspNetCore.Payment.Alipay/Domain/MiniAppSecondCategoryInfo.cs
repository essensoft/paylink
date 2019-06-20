using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppSecondCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppSecondCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 小程序类目Id
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 度假用别墅服务
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
    }
}
