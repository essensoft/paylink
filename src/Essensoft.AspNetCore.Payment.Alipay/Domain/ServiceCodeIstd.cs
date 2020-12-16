using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceCodeIstd Data Structure.
    /// </summary>
    public class ServiceCodeIstd : AlipayObject
    {
        /// <summary>
        /// 即时配送公司服务代码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
