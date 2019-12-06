using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoPrecreateCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
