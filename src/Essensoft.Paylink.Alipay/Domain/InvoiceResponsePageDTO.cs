using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceResponsePageDTO Data Structure.
    /// </summary>
    public class InvoiceResponsePageDTO : AlipayObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 发票
        /// </summary>
        [JsonPropertyName("datas")]
        public List<InvoiceAllResponseDTO> Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
