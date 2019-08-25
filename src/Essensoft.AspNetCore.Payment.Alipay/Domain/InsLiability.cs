using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsLiability Data Structure.
    /// </summary>
    [Serializable]
    public class InsLiability : AlipayObject
    {
        /// <summary>
        /// 保额
        /// </summary>
        [JsonProperty("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 是否可以编辑,0-可选; 1-不可选,不支持; 2-必选,目前不打开
        /// </summary>
        [JsonProperty("disabled")]
        public string Disabled { get; set; }

        /// <summary>
        /// 不计免赔 0，1，2
        /// </summary>
        [JsonProperty("iop")]
        public string Iop { get; set; }

        /// <summary>
        /// 不计免赔保费
        /// </summary>
        [JsonProperty("iop_premium")]
        public string IopPremium { get; set; }

        /// <summary>
        /// 责任描述
        /// </summary>
        [JsonProperty("liability_desc")]
        public string LiabilityDesc { get; set; }

        /// <summary>
        /// 责任名称
        /// </summary>
        [JsonProperty("liability_name")]
        public string LiabilityName { get; set; }

        /// <summary>
        /// 责任编码
        /// </summary>
        [JsonProperty("liability_no")]
        public string LiabilityNo { get; set; }

        /// <summary>
        /// 责任保费
        /// </summary>
        [JsonProperty("liability_premium")]
        public string LiabilityPremium { get; set; }

        /// <summary>
        /// 责任险种比率
        /// </summary>
        [JsonProperty("liability_rates")]
        public string LiabilityRates { get; set; }

        /// <summary>
        /// options
        /// </summary>
        [JsonProperty("options")]
        public List<InsOption> Options { get; set; }

        /// <summary>
        /// 责任保费
        /// </summary>
        [JsonProperty("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [JsonProperty("sum_insured")]
        public InsSumInsured SumInsured { get; set; }
    }
}
