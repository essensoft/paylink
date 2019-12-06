using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订购服务商品ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前查询页（本接口支持最多查询100条记录）
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 订单明细列表
        /// </summary>
        [JsonPropertyName("order_items")]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// 用于区分同一个服务的不同版本
        /// </summary>
        [JsonPropertyName("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// MERCHANT_ORDED（待服务商接单）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
