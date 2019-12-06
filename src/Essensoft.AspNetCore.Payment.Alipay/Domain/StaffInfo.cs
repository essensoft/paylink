using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StaffInfo Data Structure.
    /// </summary>
    public class StaffInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
