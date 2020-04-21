using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQuerygoodsreturnordeQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQuerygoodsreturnordeQueryResponse : AlipayResponse
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
        /// 退货单
        /// </summary>
        [JsonPropertyName("goods_return_orders")]
        public List<GoodsReturnOrder> GoodsReturnOrders { get; set; }

        /// <summary>
        /// 分页查询当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询每页数据量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 本次调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 查询数据总量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
