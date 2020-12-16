using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwKnowledgeModifyModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwKnowledgeModifyModel : AlipayObject
    {
        /// <summary>
        /// 所属类目ID
        /// </summary>
        [JsonPropertyName("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 知识点所属类目
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 知识点答案内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部知识点ID
        /// </summary>
        [JsonPropertyName("ext_id")]
        public string ExtId { get; set; }

        /// <summary>
        /// 扩展标题（问法）
        /// </summary>
        [JsonPropertyName("extend_titles")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 问答关联图片附件地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 知识点ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 默认为false，为true且id非空时，表示删除知识点
        /// </summary>
        [JsonPropertyName("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否被检索到，默认false，系统希望为true
        /// </summary>
        [JsonPropertyName("is_searchable")]
        public bool IsSearchable { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonPropertyName("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 关联商品信息
        /// </summary>
        [JsonPropertyName("spu")]
        public SpuDetail Spu { get; set; }

        /// <summary>
        /// 以逗号分割的字符串列表
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
