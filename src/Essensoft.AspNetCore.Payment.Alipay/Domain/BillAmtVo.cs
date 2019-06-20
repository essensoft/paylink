using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillAmtVo Data Structure.
    /// </summary>
    [Serializable]
    public class BillAmtVo : AlipayObject
    {
        /// <summary>
        /// 利息
        /// </summary>
        [JsonProperty("int_amt")]
        public MultiCurrencyMoneyVO IntAmt { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [JsonProperty("ovd_int_amt")]
        public MultiCurrencyMoneyVO OvdIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [JsonProperty("ovd_prin_amt")]
        public MultiCurrencyMoneyVO OvdPrinAmt { get; set; }

        /// <summary>
        /// 罚息
        /// </summary>
        [JsonProperty("pen_int_amt")]
        public MultiCurrencyMoneyVO PenIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [JsonProperty("pen_prin_amt")]
        public MultiCurrencyMoneyVO PenPrinAmt { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [JsonProperty("prin_amt")]
        public MultiCurrencyMoneyVO PrinAmt { get; set; }
    }
}
