using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsComponent Data Structure.
    /// </summary>
    public class GoodsComponent : AlipayObject
    {
        /// <summary>
        /// 货品code
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 组成数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
