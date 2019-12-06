using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCommissionClausePercentageResponse Data Structure.
    /// </summary>
    public class KbAdvertCommissionClausePercentageResponse : AlipayObject
    {
        /// <summary>
        /// 分佣比例(100以内精度2位的非负小数)
        /// </summary>
        [JsonPropertyName("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 封顶金额(精度2位的非负小数)
        /// </summary>
        [JsonPropertyName("max_limit")]
        public string MaxLimit { get; set; }
    }
}
