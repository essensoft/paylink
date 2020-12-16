using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceBase Data Structure.
    /// </summary>
    public class ServiceBase : AlipayObject
    {
        /// <summary>
        /// 服务载体链接
        /// </summary>
        [JsonPropertyName("service_carrier_url")]
        public string ServiceCarrierUrl { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务Logo
        /// </summary>
        [JsonPropertyName("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简述
        /// </summary>
        [JsonPropertyName("service_simple_desc")]
        public string ServiceSimpleDesc { get; set; }

        /// <summary>
        /// 服务规格
        /// </summary>
        [JsonPropertyName("service_spec_code")]
        public string ServiceSpecCode { get; set; }
    }
}
