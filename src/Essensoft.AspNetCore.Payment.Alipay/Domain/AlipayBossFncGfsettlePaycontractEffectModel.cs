using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractEffectModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractEffectModel : AlipayObject
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [JsonPropertyName("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
