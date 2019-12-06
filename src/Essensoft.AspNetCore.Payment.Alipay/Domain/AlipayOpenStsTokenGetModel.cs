using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenStsTokenGetModel Data Structure.
    /// </summary>
    public class AlipayOpenStsTokenGetModel : AlipayObject
    {
        /// <summary>
        /// 当前安全令牌
        /// </summary>
        [JsonPropertyName("security_token")]
        public string SecurityToken { get; set; }

        /// <summary>
        /// 终端运行环境信息
        /// </summary>
        [JsonPropertyName("terminal")]
        public Terminal Terminal { get; set; }
    }
}
