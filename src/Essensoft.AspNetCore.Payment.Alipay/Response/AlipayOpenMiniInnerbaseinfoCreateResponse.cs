using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
