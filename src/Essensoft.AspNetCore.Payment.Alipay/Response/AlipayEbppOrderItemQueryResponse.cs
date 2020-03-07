using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppOrderItemQueryResponse.
    /// </summary>
    public class AlipayEbppOrderItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单项
        /// </summary>
        [JsonPropertyName("item")]
        public EbppOrderItem Item { get; set; }
    }
}
