using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益ID，创建成功后返回
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
