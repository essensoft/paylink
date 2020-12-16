using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryRootDTO Data Structure.
    /// </summary>
    public class CategoryRootDTO : AlipayObject
    {
        /// <summary>
        /// 二级类目列表
        /// </summary>
        [JsonPropertyName("children")]
        public List<CategoryDTO> Children { get; set; }

        /// <summary>
        /// 一级类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
