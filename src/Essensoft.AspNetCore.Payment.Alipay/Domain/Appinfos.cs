using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Appinfos Data Structure.
    /// </summary>
    public class Appinfos : AlipayObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [JsonPropertyName("app_type")]
        public long AppType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public long MiniAppId { get; set; }
    }
}
