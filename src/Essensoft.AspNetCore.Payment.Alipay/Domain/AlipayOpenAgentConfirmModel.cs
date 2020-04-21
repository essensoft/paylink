using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAgentConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenAgentConfirmModel : AlipayObject
    {
        /// <summary>
        /// ISV 代商户操作事务编号，通过事务开启接口alipay.open.agent.create调用返回。
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }
    }
}
