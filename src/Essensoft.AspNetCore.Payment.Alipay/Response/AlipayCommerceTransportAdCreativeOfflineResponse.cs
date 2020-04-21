using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 创意下线结果 + 根据创意id操作创意下线，成功返回true，失败返回false
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
