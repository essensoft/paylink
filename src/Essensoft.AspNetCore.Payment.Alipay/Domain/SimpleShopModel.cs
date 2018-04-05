using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SimpleShopModel Data Structure.
    /// </summary>
    public class SimpleShopModel : AlipayObject
    {
        /// <summary>
        /// 商户门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }
    }
}
