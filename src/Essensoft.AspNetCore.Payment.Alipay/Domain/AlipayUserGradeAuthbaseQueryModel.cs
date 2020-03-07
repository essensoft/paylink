using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserGradeAuthbaseQueryModel Data Structure.
    /// </summary>
    public class AlipayUserGradeAuthbaseQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
