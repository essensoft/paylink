using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoSignflowsDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
