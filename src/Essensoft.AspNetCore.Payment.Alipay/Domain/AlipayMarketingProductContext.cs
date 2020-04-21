using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingProductContext Data Structure.
    /// </summary>
    public class AlipayMarketingProductContext : AlipayObject
    {
        /// <summary>
        /// 客户端client_id
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// product需要接入的时候和支付宝码平台约定。  目前仅支持建行app使用ccb_wallet
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("product_version")]
        public string ProductVersion { get; set; }
    }
}
