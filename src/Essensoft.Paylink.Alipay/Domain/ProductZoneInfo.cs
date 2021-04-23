using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductZoneInfo Data Structure.
    /// </summary>
    public class ProductZoneInfo : AlipayObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 产品原价(单位：元),保留2位小数
        /// </summary>
        [JsonPropertyName("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 区间唯一ID
        /// </summary>
        [JsonPropertyName("out_zone_id")]
        public string OutZoneId { get; set; }

        /// <summary>
        /// 产品售卖价(单位：元),保留2位小数
        /// </summary>
        [JsonPropertyName("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 库存,无限库存就99999，日历预订产品是1或0
        /// </summary>
        [JsonPropertyName("stock_count")]
        public long StockCount { get; set; }
    }
}
