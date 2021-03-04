using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
