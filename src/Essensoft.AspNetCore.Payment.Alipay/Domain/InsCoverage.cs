using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCoverage Data Structure.
    /// </summary>
    public class InsCoverage : AlipayObject
    {
        /// <summary>
        /// 险种名称
        /// </summary>
        [JsonPropertyName("coverage_name")]
        public string CoverageName { get; set; }

        /// <summary>
        /// 险种编号
        /// </summary>
        [JsonPropertyName("coverage_no")]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 险种失效时间
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 险种生效时间
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 不计免赔;0：默认不投保;  1：默认投保。
        /// </summary>
        [JsonPropertyName("iop")]
        public long Iop { get; set; }

        /// <summary>
        /// 不计免赔的保费
        /// </summary>
        [JsonPropertyName("iop_premium")]
        public long IopPremium { get; set; }

        /// <summary>
        /// 保费;单位分
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保额;单位分
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
