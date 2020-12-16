using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
