using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityParticipatedQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantActivityParticipatedQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID，唯一键标识用户身份。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
