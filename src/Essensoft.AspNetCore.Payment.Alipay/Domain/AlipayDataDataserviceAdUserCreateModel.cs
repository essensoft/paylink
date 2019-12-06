using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserCreateModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 投放账户支付宝PID
        /// </summary>
        [JsonPropertyName("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 账户状态，ENABLE-生效；DISABLE-失效。若为空，则默认有效。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
