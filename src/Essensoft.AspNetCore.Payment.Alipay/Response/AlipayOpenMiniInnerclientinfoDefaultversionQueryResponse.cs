using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoDefaultversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoDefaultversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// Android客户端版本信息
        /// </summary>
        [JsonPropertyName("android_client_version_info")]
        public MiniAppClientVersionInfo AndroidClientVersionInfo { get; set; }

        /// <summary>
        /// iOS客户单版本号信息
        /// </summary>
        [JsonPropertyName("ios_client_version_info")]
        public MiniAppClientVersionInfo IosClientVersionInfo { get; set; }
    }
}
