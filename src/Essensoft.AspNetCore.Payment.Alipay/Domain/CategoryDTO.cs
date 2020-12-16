using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryDTO Data Structure.
    /// </summary>
    public class CategoryDTO : AlipayObject
    {
        /// <summary>
        /// 门店码类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 叶子节点类目列表
        /// </summary>
        [JsonPropertyName("leaf_cates")]
        public List<CategoryLeafDTO> LeafCates { get; set; }

        /// <summary>
        /// 门店码类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
