using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainShopCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝内部店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
