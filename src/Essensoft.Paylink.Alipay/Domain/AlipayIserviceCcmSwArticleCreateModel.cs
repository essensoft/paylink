using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwArticleCreateModel : AlipayObject
    {
        /// <summary>
        /// 所属类目ID，如果search_all_category为true则不用填
        /// </summary>
        [JsonPropertyName("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        [JsonPropertyName("extend_titles")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）
        /// </summary>
        [JsonPropertyName("scene_codes")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
