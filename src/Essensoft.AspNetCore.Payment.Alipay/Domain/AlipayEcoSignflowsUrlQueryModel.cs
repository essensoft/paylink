using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsUrlQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoSignflowsUrlQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程id
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
