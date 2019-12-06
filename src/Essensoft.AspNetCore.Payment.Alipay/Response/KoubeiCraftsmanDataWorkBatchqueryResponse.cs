using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkBatchqueryResponse : AlipayResponse
    {
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
        /// 总页码数目
        /// </summary>
        [JsonPropertyName("total_page_no")]
        public long TotalPageNo { get; set; }

        /// <summary>
        /// 总共手艺人作品数目
        /// </summary>
        [JsonPropertyName("total_works")]
        public long TotalWorks { get; set; }

        /// <summary>
        /// 作品信息列表
        /// </summary>
        [JsonPropertyName("works")]
        public List<CraftsmanWorkOpenModel> Works { get; set; }
    }
}
