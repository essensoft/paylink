using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorSearchBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 操作员信息列表
        /// </summary>
        [JsonPropertyName("operator_info_models")]
        public List<OperatorInfoModel> OperatorInfoModels { get; set; }

        /// <summary>
        /// 总数据量
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
