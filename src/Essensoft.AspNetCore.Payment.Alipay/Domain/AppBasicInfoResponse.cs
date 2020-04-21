using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppBasicInfoResponse Data Structure.
    /// </summary>
    public class AppBasicInfoResponse : AlipayObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("open_app_id")]
        public string OpenAppId { get; set; }

        /// <summary>
        /// 应用的名称
        /// </summary>
        [JsonPropertyName("open_app_name")]
        public string OpenAppName { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("open_app_type")]
        public string OpenAppType { get; set; }
    }
}
