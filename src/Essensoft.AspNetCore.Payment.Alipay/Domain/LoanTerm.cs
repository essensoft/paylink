using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanTerm Data Structure.
    /// </summary>
    [Serializable]
    public class LoanTerm : AlipayObject
    {
        /// <summary>
        /// 贷款期数
        /// </summary>
        [JsonProperty("term")]
        public long Term { get; set; }

        /// <summary>
        /// 贷款期限单位，取值{D, M, Y}：D-日; M-月; Y-年
        /// </summary>
        [JsonProperty("term_unit")]
        public string TermUnit { get; set; }
    }
}
