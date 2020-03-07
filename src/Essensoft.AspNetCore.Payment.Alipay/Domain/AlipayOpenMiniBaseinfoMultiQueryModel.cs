using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoMultiQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniBaseinfoMultiQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
