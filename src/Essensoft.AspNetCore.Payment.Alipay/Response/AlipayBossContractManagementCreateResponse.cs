using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossContractManagementCreateResponse.
    /// </summary>
    public class AlipayBossContractManagementCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 发起审批返回结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public InterTradeStartContractApprovalResult ResultSet { get; set; }
    }
}
