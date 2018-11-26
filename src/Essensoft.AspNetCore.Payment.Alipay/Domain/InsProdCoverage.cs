using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsProdCoverage Data Structure.
    /// </summary>
    [Serializable]
    public class InsProdCoverage : AlipayObject
    {
        /// <summary>
        /// 险种描述
        /// </summary>
        [JsonProperty("coverage_desc")]
        [XmlElement("coverage_desc")]
        public string CoverageDesc { get; set; }

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
        /// 是否定期险种
        /// </summary>
        [JsonProperty("is_fixed_period")]
        [XmlElement("is_fixed_period")]
        public bool IsFixedPeriod { get; set; }

        /// <summary>
        /// 险种责任列表
        /// </summary>
        [JsonProperty("liabilities")]
        [XmlArray("liabilities")]
        [XmlArrayItem("ins_liability")]
        public List<InsLiability> Liabilities { get; set; }

        /// <summary>
        /// 可用的保障期限列表;约定“1D”代表一天，“1M”代表一个月,"1Y"代表一年
        /// </summary>
        [JsonProperty("periods")]
        [XmlArray("periods")]
        [XmlArrayItem("string")]
        public List<string> Periods { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [JsonProperty("sum_insured")]
        [XmlElement("sum_insured")]
        public InsSumInsured SumInsured { get; set; }
    }
}
