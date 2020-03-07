using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoBenefitCheckavailableResponse.
    /// </summary>
    public class AlipayInsAutoBenefitCheckavailableResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可以使用，0-否，1-是
        /// </summary>
        [JsonPropertyName("available")]
        public string Available { get; set; }

        /// <summary>
        /// 频次规则详情，为空表示没有频次规则限制
        /// </summary>
        [JsonPropertyName("frequency_rule_detail")]
        public FrequencyRuleDetail FrequencyRuleDetail { get; set; }

        /// <summary>
        /// available =0时有值，无使用资格的原因。no_qualification-没有资格，over_frequency-频次超限
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
