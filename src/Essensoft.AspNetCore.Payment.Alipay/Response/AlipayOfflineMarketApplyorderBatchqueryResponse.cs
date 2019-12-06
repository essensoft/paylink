using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketApplyorderBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketApplyorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝操作流水信息列表
        /// </summary>
        [JsonPropertyName("biz_order_infos")]
        public List<BizOrderQueryResponse> BizOrderInfos { get; set; }

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
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonPropertyName("total_page_no")]
        public long TotalPageNo { get; set; }
    }
}
