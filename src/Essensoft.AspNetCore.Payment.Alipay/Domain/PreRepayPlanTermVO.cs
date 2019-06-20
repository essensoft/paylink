using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreRepayPlanTermVO Data Structure.
    /// </summary>
    [Serializable]
    public class PreRepayPlanTermVO : AlipayObject
    {
        /// <summary>
        /// 当期利息
        /// </summary>
        [JsonProperty("int_bal")]
        public string IntBal { get; set; }

        /// <summary>
        /// 当期本金
        /// </summary>
        [JsonProperty("prin_bal")]
        public string PrinBal { get; set; }

        /// <summary>
        /// 当期应还总额=当期本金+当期利息
        /// </summary>
        [JsonProperty("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 本期到期日，即应还款日期
        /// </summary>
        [JsonProperty("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次号
        /// </summary>
        [JsonProperty("term_no")]
        public long TermNo { get; set; }
    }
}
