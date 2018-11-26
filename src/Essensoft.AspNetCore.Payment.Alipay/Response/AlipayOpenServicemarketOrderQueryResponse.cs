using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("commodity_id")]
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前查询页（本接口支持最多查询100条记录）
        /// </summary>
        [JsonProperty("current_page")]
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 订单明细列表
        /// </summary>
        [JsonProperty("order_items")]
        [XmlArray("order_items")]
        [XmlArrayItem("order_item")]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// 用于区分同一个服务的不同版本
        /// </summary>
        [JsonProperty("specifications")]
        [XmlElement("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// MERCHANT_ORDED（待服务商接单）
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_size")]
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
