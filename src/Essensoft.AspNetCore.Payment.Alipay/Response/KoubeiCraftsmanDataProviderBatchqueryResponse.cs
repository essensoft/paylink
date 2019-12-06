using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataProviderBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataProviderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// craftsmans:手艺人信息
        /// </summary>
        [JsonPropertyName("craftsmans")]
        public List<CraftsmanOpenModel> Craftsmans { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店下共手艺人数目
        /// </summary>
        [JsonPropertyName("total_craftsmans")]
        public long TotalCraftsmans { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonPropertyName("total_page_no")]
        public long TotalPageNo { get; set; }
    }
}
