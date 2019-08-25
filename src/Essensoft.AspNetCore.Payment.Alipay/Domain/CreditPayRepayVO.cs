using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayRepayVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayRepayVO : AlipayObject
    {
        /// <summary>
        /// 首期合并天数，如果距离本月还款日不足首期合并天数，将推迟到下个月还款
        /// </summary>
        [JsonProperty("first_merge_day")]
        public string FirstMergeDay { get; set; }

        /// <summary>
        /// 统一还款日，每个月的哪一天还
        /// </summary>
        [JsonProperty("repay_day")]
        public string RepayDay { get; set; }

        /// <summary>
        /// 还款文案
        /// </summary>
        [JsonProperty("repay_desc")]
        public string RepayDesc { get; set; }

        /// <summary>
        /// 1=EQUAL_LOAN_PAYMENT=等额本息,2=EQUAL_PRIN_PAYMENT=等额本金,3=PAY_INT_ON_SHCED_PAY_PRIN_AT_DUE_DAY=组合还款,4=MIX_PAYMENT=组合还款,6=DUE_PRIN_PLUS_INT=一次性到期还本付息,7=AVG_CAP_PLUS_INT_BY_TERM=固定利息等额分期,8=EQUAL_PRIN_EQUAL_PAYMENT=等本等费
        /// </summary>
        [JsonProperty("repay_mode")]
        public string RepayMode { get; set; }
    }
}
