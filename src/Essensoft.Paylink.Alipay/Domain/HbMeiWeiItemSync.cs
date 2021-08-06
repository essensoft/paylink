using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HbMeiWeiItemSync Data Structure.
    /// </summary>
    public class HbMeiWeiItemSync : AlipayObject
    {
        /// <summary>
        /// 宝贝票面价值,单位为分
        /// </summary>
        [JsonPropertyName("amount_rights")]
        public long AmountRights { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [JsonPropertyName("biz_item_id")]
        public string BizItemId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 宝贝售价,单位为分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [JsonPropertyName("sale_count")]
        public long SaleCount { get; set; }

        /// <summary>
        /// 宝贝状态，1:上架状态，0:下架状态，默认为0
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 访问量
        /// </summary>
        [JsonPropertyName("uv_count")]
        public long UvCount { get; set; }
    }
}
