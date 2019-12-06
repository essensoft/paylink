using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSmsSendModel Data Structure.
    /// </summary>
    public class AlipayEcoSmsSendModel : AlipayObject
    {
        /// <summary>
        /// 发送内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 待收信人手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
