using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceBuyModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmServiceBuyModel : AlipayObject
    {
        /// <summary>
        /// 服务代码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
