using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayChargePricingVO Data Structure.
    /// </summary>
    public class CreditPayChargePricingVO : AlipayObject
    {
        /// <summary>
        /// 实际费用，单位元
        /// </summary>
        [JsonPropertyName("actual_charge")]
        public string ActualCharge { get; set; }

        /// <summary>
        /// 实际费率，小数形式
        /// </summary>
        [JsonPropertyName("actual_charge_rate")]
        public string ActualChargeRate { get; set; }

        /// <summary>
        /// 费用名目
        /// </summary>
        [JsonPropertyName("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 原始费用，单位元
        /// </summary>
        [JsonPropertyName("origin_charge")]
        public string OriginCharge { get; set; }

        /// <summary>
        /// 原始费率，小数形式
        /// </summary>
        [JsonPropertyName("origin_charge_rate")]
        public string OriginChargeRate { get; set; }
    }
}
