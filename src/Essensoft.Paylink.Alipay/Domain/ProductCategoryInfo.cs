using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductCategoryInfo Data Structure.
    /// </summary>
    public class ProductCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 使用日期，暂不可跨天
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类别唯一ID
        /// </summary>
        [JsonPropertyName("out_category_id")]
        public string OutCategoryId { get; set; }

        /// <summary>
        /// 类别下的区间列表
        /// </summary>
        [JsonPropertyName("zone_list")]
        public List<ProductZoneInfo> ZoneList { get; set; }
    }
}
