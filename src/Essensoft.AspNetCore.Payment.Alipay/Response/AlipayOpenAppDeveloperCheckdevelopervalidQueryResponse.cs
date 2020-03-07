using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryResponse.
    /// </summary>
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝账号入驻开放平台有效性检查，true表示有效，false无效
        /// </summary>
        [JsonPropertyName("dev_valid")]
        public bool DevValid { get; set; }
    }
}
