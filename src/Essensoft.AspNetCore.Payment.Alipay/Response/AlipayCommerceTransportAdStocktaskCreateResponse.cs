using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 库存查询任务id +  库存查询任务的唯一标识，可使用该ID进行库存任务详情查询
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
