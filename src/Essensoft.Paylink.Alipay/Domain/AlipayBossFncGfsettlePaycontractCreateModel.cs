using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractCreateModel : AlipayObject
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [JsonPropertyName("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
