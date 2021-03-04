using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowFinishModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowFinishModel : AlipayObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
