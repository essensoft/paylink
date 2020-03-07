using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InterTradeStartContractApprovalResult Data Structure.
    /// </summary>
    public class InterTradeStartContractApprovalResult : AlipayObject
    {
        /// <summary>
        /// true：需要蚂蚁关联交易审批 false：不需要蚂蚁关联交易审批
        /// </summary>
        [JsonPropertyName("need_approval_flag")]
        public bool NeedApprovalFlag { get; set; }
    }
}
