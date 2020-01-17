using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
