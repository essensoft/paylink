using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliosOpenAutoInfoQueryModel Data Structure.
    /// </summary>
    public class AliosOpenAutoInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备token
        /// </summary>
        [JsonPropertyName("device_token")]
        public string DeviceToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
