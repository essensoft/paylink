using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单列表
        /// </summary>
        [JsonPropertyName("data")]
        public OrderPageQueryDTO Data { get; set; }
    }
}
