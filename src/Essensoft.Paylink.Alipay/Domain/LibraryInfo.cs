using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// LibraryInfo Data Structure.
    /// </summary>
    public class LibraryInfo : AlipayObject
    {
        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("tree_id")]
        public long TreeId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; }
    }
}
