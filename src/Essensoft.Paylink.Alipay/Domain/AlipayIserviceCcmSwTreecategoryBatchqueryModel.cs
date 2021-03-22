using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页数，page_size不能为空
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页显示大小，page_num不能为空
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
