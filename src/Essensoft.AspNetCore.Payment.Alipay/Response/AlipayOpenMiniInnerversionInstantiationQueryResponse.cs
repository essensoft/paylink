using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInstantiationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionInstantiationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板的版本号
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }
    }
}
