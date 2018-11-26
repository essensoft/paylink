using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class InsCoverage : AlipayObject
    {
        /// <summary>
        /// 险种名称
        /// </summary>
        [JsonProperty("coverage_name")]
        [XmlElement("coverage_name")]
        public string CoverageName { get; set; }

        /// <summary>
        /// 险种编号
        /// </summary>
        [JsonProperty("coverage_no")]
        [XmlElement("coverage_no")]
        public string CoverageNo { get; set; }

        /// <summary>
        /// 险种失效时间
        /// </summary>
        [JsonProperty("effect_end_time")]
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 险种生效时间
        /// </summary>
        [JsonProperty("effect_start_time")]
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 不计免赔;0：默认不投保;  1：默认投保。
        /// </summary>
        [JsonProperty("iop")]
        [XmlElement("iop")]
        public long Iop { get; set; }

        /// <summary>
        /// 不计免赔的保费
        /// </summary>
        [JsonProperty("iop_premium")]
        [XmlElement("iop_premium")]
        public long IopPremium { get; set; }

        /// <summary>
        /// 保费;单位分
        /// </summary>
        [JsonProperty("premium")]
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保额;单位分
        /// </summary>
        [JsonProperty("sum_insured")]
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
