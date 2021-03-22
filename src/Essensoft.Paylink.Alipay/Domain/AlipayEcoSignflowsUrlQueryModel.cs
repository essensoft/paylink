using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsUrlQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoSignflowsUrlQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程id，通过 <a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 创建流程时指定企业唯一标识
        /// </summary>
        [JsonPropertyName("org_third_party_user_id")]
        public string OrgThirdPartyUserId { get; set; }

        /// <summary>
        /// 创建流程时指定个人唯一标识
        /// </summary>
        [JsonPropertyName("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
