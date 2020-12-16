using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantShopcodeApplyorderBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantShopcodeApplyorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("cur_page_no")]
        public long CurPageNo { get; set; }

        /// <summary>
        /// 门店码开通流水详情
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<OrderInfoDTO> OrderList { get; set; }

        /// <summary>
        /// 当前页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 本次查询总记录数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 本次查询总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
