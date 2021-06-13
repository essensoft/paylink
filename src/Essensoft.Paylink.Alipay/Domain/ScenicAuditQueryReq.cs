using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ScenicAuditQueryReq Data Structure.
    /// </summary>
    public class ScenicAuditQueryReq : AlipayObject
    {
        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [JsonPropertyName("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [JsonPropertyName("scenic_id")]
        public string ScenicId { get; set; }
    }
}
