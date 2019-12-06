using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandMerchantTypeQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandMerchantTypeQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
