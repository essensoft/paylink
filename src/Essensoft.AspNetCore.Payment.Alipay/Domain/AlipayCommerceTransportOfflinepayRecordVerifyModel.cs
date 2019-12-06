using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayRecordVerifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayRecordVerifyModel : AlipayObject
    {
        /// <summary>
        /// 原始脱机记录信息
        /// </summary>
        [JsonPropertyName("record")]
        public string Record { get; set; }
    }
}
