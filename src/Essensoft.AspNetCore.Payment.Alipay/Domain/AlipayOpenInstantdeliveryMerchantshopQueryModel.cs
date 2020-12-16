using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopQueryModel : AlipayObject
    {
        /// <summary>
        /// 商家门店编码。
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
