using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SCardQueryVO Data Structure.
    /// </summary>
    public class SCardQueryVO : AlipayObject
    {
        /// <summary>
        /// 背景图
        /// </summary>
        [JsonPropertyName("back_img")]
        public string BackImg { get; set; }

        /// <summary>
        /// 权益价值-单位分
        /// </summary>
        [JsonPropertyName("item_amount")]
        public long ItemAmount { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 优惠信息名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 售卖价格-单位分
        /// </summary>
        [JsonPropertyName("sale_price")]
        public long SalePrice { get; set; }
    }
}
