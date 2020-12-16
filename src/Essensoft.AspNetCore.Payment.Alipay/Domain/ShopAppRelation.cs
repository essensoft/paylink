using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopAppRelation Data Structure.
    /// </summary>
    public class ShopAppRelation : AlipayObject
    {
        /// <summary>
        /// 支付宝门店ID，在支付宝商户平台维护的线下门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 待绑定的支付宝小程序ID
        /// </summary>
        [JsonPropertyName("store_app_id")]
        public string StoreAppId { get; set; }
    }
}
