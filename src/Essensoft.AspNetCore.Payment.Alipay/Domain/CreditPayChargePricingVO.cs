using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayChargePricingVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayChargePricingVO : AlipayObject
    {
        /// <summary>
        /// 实际费用，单位元
        /// </summary>
        [JsonProperty("actual_charge")]
        public string ActualCharge { get; set; }

        /// <summary>
        /// 实际费率，小数形式
        /// </summary>
        [JsonProperty("actual_charge_rate")]
        public string ActualChargeRate { get; set; }

        /// <summary>
        /// 费用名目
        /// </summary>
        [JsonProperty("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 原始费用，单位元
        /// </summary>
        [JsonProperty("origin_charge")]
        public string OriginCharge { get; set; }

        /// <summary>
        /// 原始费率，小数形式
        /// </summary>
        [JsonProperty("origin_charge_rate")]
        public string OriginChargeRate { get; set; }
    }
}
