using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserFamilyArchiveInitializeResponse.
    /// </summary>
    public class AlipayUserFamilyArchiveInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 家人信息档案(选人授权)组件唤起地址
        /// </summary>
        [JsonPropertyName("archive_plugin_url")]
        public string ArchivePluginUrl { get; set; }
    }
}
