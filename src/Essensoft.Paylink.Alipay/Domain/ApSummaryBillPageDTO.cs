using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApSummaryBillPageDTO Data Structure.
    /// </summary>
    public class ApSummaryBillPageDTO : AlipayObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("datas")]
        public ApSummaryBillResponseDTO Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
