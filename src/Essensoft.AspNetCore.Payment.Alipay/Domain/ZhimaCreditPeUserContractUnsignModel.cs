using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserContractUnsignModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeUserContractUnsignModel : AlipayObject
    {
        /// <summary>
        /// 芝麻信用场景，由芝麻信用侧分配，如：天猫信用购，淘宝租赁等
        /// </summary>
        [JsonPropertyName("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
