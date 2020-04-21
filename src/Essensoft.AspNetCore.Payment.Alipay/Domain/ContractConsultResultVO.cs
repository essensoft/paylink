using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractConsultResultVO Data Structure.
    /// </summary>
    public class ContractConsultResultVO : AlipayObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 是否需要审批
        /// </summary>
        [JsonPropertyName("need_approval")]
        public bool NeedApproval { get; set; }
    }
}
