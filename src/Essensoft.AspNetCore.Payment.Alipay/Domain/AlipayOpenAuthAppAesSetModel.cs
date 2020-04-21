using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppAesSetModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppAesSetModel : AlipayObject
    {
        /// <summary>
        /// 商家应用appId
        /// </summary>
        [JsonPropertyName("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
