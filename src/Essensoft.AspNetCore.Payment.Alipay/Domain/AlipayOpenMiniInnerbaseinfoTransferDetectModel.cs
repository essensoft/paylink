using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoTransferDetectModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoTransferDetectModel : AlipayObject
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 需要迁移校验的小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
