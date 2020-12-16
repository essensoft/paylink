using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantShopDTO Data Structure.
    /// </summary>
    public class MerchantShopDTO : AlipayObject
    {
        /// <summary>
        /// 门店名称，最长不超过256个字符。
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号。
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
