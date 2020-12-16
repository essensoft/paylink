using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayAppCarSignModel Data Structure.
    /// </summary>
    public class AlipayPayAppCarSignModel : AlipayObject
    {
        /// <summary>
        /// 当前登录的用户ID
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
