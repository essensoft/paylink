using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncresultQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelGoodsSyncresultQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部商户或第三方的商品ID
        /// </summary>
        [JsonPropertyName("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 外部店铺ID，对于特定行业可选，比如GOL线上商品的场景非必填
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }
    }
}
