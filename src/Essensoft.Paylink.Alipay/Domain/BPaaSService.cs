using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BPaaSService Data Structure.
    /// </summary>
    public class BPaaSService : AlipayObject
    {
        /// <summary>
        /// 服务是否需要签约
        /// </summary>
        [JsonPropertyName("if_sign")]
        public bool IfSign { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务版本号
        /// </summary>
        [JsonPropertyName("service_version")]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [JsonPropertyName("slogan")]
        public string Slogan { get; set; }
    }
}
