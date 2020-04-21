using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 主账号ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
