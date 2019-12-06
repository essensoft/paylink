using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardInfo Data Structure.
    /// </summary>
    public class CardInfo : AlipayObject
    {
        /// <summary>
        /// 领取时间
        /// </summary>
        [JsonPropertyName("taken_time")]
        public string TakenTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
