using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishCategoryEntity Data Structure.
    /// </summary>
    public class DishCategoryEntity : AlipayObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonPropertyName("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}
