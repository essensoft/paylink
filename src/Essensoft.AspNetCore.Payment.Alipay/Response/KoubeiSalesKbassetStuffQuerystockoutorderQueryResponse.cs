using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQuerystockoutorderQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQuerystockoutorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 异常码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 异常描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 出库单
        /// </summary>
        [JsonPropertyName("stock_out_orders")]
        public List<StuffStockOutOrder> StockOutOrders { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
