using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoDefaultversionQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoDefaultversionQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序Id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
