using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppVersionQueryInfo Data Structure.
    /// </summary>
    public class MiniAppVersionQueryInfo : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }
    }
}
