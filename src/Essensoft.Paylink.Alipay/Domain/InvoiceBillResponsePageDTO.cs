using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceBillResponsePageDTO Data Structure.
    /// </summary>
    public class InvoiceBillResponsePageDTO : AlipayObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 发票关联的账单
        /// </summary>
        [JsonPropertyName("datas")]
        public InvoiceBillResponseDTO Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
