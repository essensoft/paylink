using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CourseSKUInfo Data Structure.
    /// </summary>
    public class CourseSKUInfo : AlipayObject
    {
        /// <summary>
        /// 课程数量
        /// </summary>
        [JsonPropertyName("course_num")]
        public long CourseNum { get; set; }

        /// <summary>
        /// 现价(单位 : 分)
        /// </summary>
        [JsonPropertyName("cur_price")]
        public long CurPrice { get; set; }

        /// <summary>
        /// 原价(单位 : 分)
        /// </summary>
        [JsonPropertyName("ori_price")]
        public long OriPrice { get; set; }

        /// <summary>
        /// 外部skuId
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [JsonPropertyName("stock_num")]
        public long StockNum { get; set; }
    }
}
