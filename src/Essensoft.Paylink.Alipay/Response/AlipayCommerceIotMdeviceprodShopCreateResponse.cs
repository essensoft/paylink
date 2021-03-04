using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 虚拟门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
