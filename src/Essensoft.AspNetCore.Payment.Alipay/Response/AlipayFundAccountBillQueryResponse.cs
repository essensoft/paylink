using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundAccountBillQueryResponse.
    /// </summary>
    public class AlipayFundAccountBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单详情
        /// </summary>
        [JsonPropertyName("acc_detail_list")]
        public List<TrusteeshipAccountBillQueryResponse> AccDetailList { get; set; }

        /// <summary>
        /// 结果页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 结果页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 每页元素数
        /// </summary>
        [JsonPropertyName("total_item_count")]
        public string TotalItemCount { get; set; }
    }
}
