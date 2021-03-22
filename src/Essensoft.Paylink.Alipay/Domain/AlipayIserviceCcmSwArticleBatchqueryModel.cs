using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwArticleBatchqueryModel : AlipayObject
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
        /// 结束时间，并且开始时间不能为空
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 文章ID集合
        /// </summary>
        [JsonPropertyName("ids")]
        public List<long> Ids { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }

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
        /// 页数，page_size不能为空
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，page_num不能为空
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 是否搜索所有类目，如果为true则不用填写category_id值
        /// </summary>
        [JsonPropertyName("search_all_category")]
        public bool SearchAllCategory { get; set; }

        /// <summary>
        /// Current（搜索当前节点）； Children（搜索当前节点以及子节点）
        /// </summary>
        [JsonPropertyName("search_category_type")]
        public string SearchCategoryType { get; set; }

        /// <summary>
        /// 开始时间，并且结束时间不能为空
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态，PUBLISHED（已发布），UNPUBLISH（未发布），EXPIRED（失效），DELETED（已删除）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
