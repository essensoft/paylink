using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程id，通过 <a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
