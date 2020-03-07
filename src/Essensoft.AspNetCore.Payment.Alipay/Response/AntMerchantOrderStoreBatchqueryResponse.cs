using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantOrderStoreBatchqueryResponse.
    /// </summary>
    public class AntMerchantOrderStoreBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<StoreOrderDTO> OrderList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询总数量
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
