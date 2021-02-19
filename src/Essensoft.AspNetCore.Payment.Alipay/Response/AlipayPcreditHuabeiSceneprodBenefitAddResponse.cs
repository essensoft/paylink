using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitAddResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitAddResponse : AlipayResponse
    {
        /// <summary>
        /// 追加预算流水ID
        /// </summary>
        [JsonPropertyName("append_id")]
        public string AppendId { get; set; }
    }
}
