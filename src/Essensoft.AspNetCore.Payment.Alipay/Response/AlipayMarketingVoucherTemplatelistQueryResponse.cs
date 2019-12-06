using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatelistQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherTemplatelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码,页码从1开始
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [JsonPropertyName("voucher_templates")]
        public List<VoucherTemplateLiteInfo> VoucherTemplates { get; set; }
    }
}
