using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppServiceResult Data Structure.
    /// </summary>
    public class AppServiceResult : AlipayObject
    {
        /// <summary>
        /// 跳转地址
        /// </summary>
        [JsonPropertyName("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 子服务的logo地址
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [JsonPropertyName("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
