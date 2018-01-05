using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MiniAppCategoryInfo Data Structure.
    /// </summary>
    public class MiniAppCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        [JsonProperty("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [JsonProperty("first_category_name")]
        public string FirstCategoryName { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        [JsonProperty("second_category_id")]
        public string SecondCategoryId { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [JsonProperty("second_category_name")]
        public string SecondCategoryName { get; set; }
    }
}
