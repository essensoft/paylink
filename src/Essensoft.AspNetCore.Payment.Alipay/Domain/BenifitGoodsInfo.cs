using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenifitGoodsInfo Data Structure.
    /// </summary>
    public class BenifitGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息，预留字段，非必录项
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// ISV对应的商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// ISV对应的商品标题
        /// </summary>
        [JsonPropertyName("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// ISV对应的商品类型
        /// </summary>
        [JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }
    }
}
