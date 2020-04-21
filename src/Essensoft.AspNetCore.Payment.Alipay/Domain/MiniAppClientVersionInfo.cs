using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppClientVersionInfo Data Structure.
    /// </summary>
    public class MiniAppClientVersionInfo : AlipayObject
    {
        /// <summary>
        /// 最大客户端版本号信息
        /// </summary>
        [JsonPropertyName("max_client_version")]
        public string MaxClientVersion { get; set; }

        /// <summary>
        /// 最小客户端版本号
        /// </summary>
        [JsonPropertyName("min_client_version")]
        public string MinClientVersion { get; set; }
    }
}
