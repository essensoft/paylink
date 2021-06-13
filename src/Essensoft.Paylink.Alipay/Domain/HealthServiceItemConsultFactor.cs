using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HealthServiceItemConsultFactor Data Structure.
    /// </summary>
    public class HealthServiceItemConsultFactor : AlipayObject
    {
        /// <summary>
        /// 咨询因子Key
        /// </summary>
        [JsonPropertyName("factor_key")]
        public string FactorKey { get; set; }

        /// <summary>
        /// 咨询因子值
        /// </summary>
        [JsonPropertyName("factor_value")]
        public string FactorValue { get; set; }
    }
}
