using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InsurancePeriod Data Structure.
    /// </summary>
    public class InsurancePeriod : AlipayObject
    {
        /// <summary>
        /// 保障期限，正整数
        /// </summary>
        [JsonPropertyName("period")]
        public long Period { get; set; }

        /// <summary>
        /// 保障期限单位，年月日 枚举:YEAR/MONTH/DAY
        /// </summary>
        [JsonPropertyName("period_unit")]
        public string PeriodUnit { get; set; }
    }
}
