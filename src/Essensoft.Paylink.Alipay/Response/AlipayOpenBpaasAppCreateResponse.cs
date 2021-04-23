using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenBpaasAppCreateResponse.
    /// </summary>
    public class AlipayOpenBpaasAppCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用平台类型：ANDROID、RTOS、LINUX、WINDOWS
        /// </summary>
        [JsonPropertyName("app_platform")]
        public string AppPlatform { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// bpaas应用ID
        /// </summary>
        [JsonPropertyName("bpaas_app_id")]
        public string BpaasAppId { get; set; }
    }
}
