using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowCancelModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowCancelModel : AlipayObject
    {
        /// <summary>
        /// 流程id，通过 <a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 撤销原因，默认为"撤销"。商家可自定义。
        /// </summary>
        [JsonPropertyName("revoke_reason")]
        public string RevokeReason { get; set; }
    }
}
