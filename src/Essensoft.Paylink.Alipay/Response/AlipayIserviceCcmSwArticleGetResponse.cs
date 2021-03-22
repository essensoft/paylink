using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleGetResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleGetResponse : AlipayResponse
    {
        /// <summary>
        /// 文章对应附件集合
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<ArticleAttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// 所属类目ID
        /// </summary>
        [JsonPropertyName("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目名称路径
        /// </summary>
        [JsonPropertyName("category_name_path")]
        public string CategoryNamePath { get; set; }

        /// <summary>
        /// 类目路径
        /// </summary>
        [JsonPropertyName("category_path")]
        public List<ArticleCategoryInfo> CategoryPath { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        [JsonPropertyName("extend_titles")]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [JsonPropertyName("order_no")]
        public long OrderNo { get; set; }

        /// <summary>
        /// 文章对应图片集合
        /// </summary>
        [JsonPropertyName("pictures")]
        public List<ArticleAttachmentInfo> Pictures { get; set; }

        /// <summary>
        /// 有效期止
        /// </summary>
        [JsonPropertyName("publish_end")]
        public string PublishEnd { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [JsonPropertyName("publish_start")]
        public string PublishStart { get; set; }

        /// <summary>
        /// 场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）
        /// </summary>
        [JsonPropertyName("scene_codes")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 文章状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 文章状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("updater_id")]
        public string UpdaterId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [JsonPropertyName("updater_name")]
        public string UpdaterName { get; set; }
    }
}
