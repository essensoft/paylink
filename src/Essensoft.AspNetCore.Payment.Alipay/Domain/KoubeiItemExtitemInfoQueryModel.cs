using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }
    }
}
