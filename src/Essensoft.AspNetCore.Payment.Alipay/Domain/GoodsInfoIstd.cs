using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsInfoIstd Data Structure.
    /// </summary>
    public class GoodsInfoIstd : AlipayObject
    {
        /// <summary>
        /// 交货信息，用于骑手交付商品
        /// </summary>
        [JsonPropertyName("delivery_info")]
        public string DeliveryInfo { get; set; }

        /// <summary>
        /// 一级品类类目
        /// </summary>
        [JsonPropertyName("first_class")]
        public string FirstClass { get; set; }

        /// <summary>
        /// 商品高度，单位为cm，精确到小数点后面两位
        /// </summary>
        [JsonPropertyName("height")]
        public long Height { get; set; }

        /// <summary>
        /// 商品长度，单位为cm，精确到小数点后面两位
        /// </summary>
        [JsonPropertyName("length")]
        public long Length { get; set; }

        /// <summary>
        /// 取货信息，用于骑手到店取货
        /// </summary>
        [JsonPropertyName("pickup_info")]
        public string PickupInfo { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 二级品类类目
        /// </summary>
        [JsonPropertyName("second_class")]
        public string SecondClass { get; set; }

        /// <summary>
        /// 货物重量，单位为kg，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("weight")]
        public long Weight { get; set; }

        /// <summary>
        /// 商品宽度，单位为cm，精确到小数点后面两位
        /// </summary>
        [JsonPropertyName("width")]
        public long Width { get; set; }
    }
}
