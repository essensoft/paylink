using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryVO Data Structure.
    /// </summary>
    public class CategoryVO : AlipayObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 1表示有效，0表示无效
        /// </summary>
        [JsonPropertyName("enable")]
        public long Enable { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 父类目ID
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 根类目ID
        /// </summary>
        [JsonPropertyName("root_id")]
        public string RootId { get; set; }
    }
}
