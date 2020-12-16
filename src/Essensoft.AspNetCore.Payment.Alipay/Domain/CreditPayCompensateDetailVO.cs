using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayCompensateDetailVO Data Structure.
    /// </summary>
    public class CreditPayCompensateDetailVO : AlipayObject
    {
        /// <summary>
        /// 费用列表
        /// </summary>
        [JsonPropertyName("charge_pricing_list")]
        public List<CreditPayChargePricingVO> ChargePricingList { get; set; }

        /// <summary>
        /// 条款视图列表
        /// </summary>
        [JsonPropertyName("clauses")]
        public List<CreditPayClauseVO> Clauses { get; set; }

        /// <summary>
        /// 分期间隔
        /// </summary>
        [JsonPropertyName("instal_itrv")]
        public string InstalItrv { get; set; }

        /// <summary>
        /// 分期类型(D-日，M-月，Y-年)
        /// </summary>
        [JsonPropertyName("instal_type")]
        public string InstalType { get; set; }

        /// <summary>
        /// 利息定价
        /// </summary>
        [JsonPropertyName("int_pricing")]
        public CreditPayIntPricingVO IntPricing { get; set; }
    }
}
