using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommunityServiceInfo Data Structure.
    /// </summary>
    public class CommunityServiceInfo : AlipayObject
    {
        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
