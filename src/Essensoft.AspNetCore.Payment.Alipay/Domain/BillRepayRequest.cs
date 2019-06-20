using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillRepayRequest Data Structure.
    /// </summary>
    [Serializable]
    public class BillRepayRequest : AlipayObject
    {
        /// <summary>
        /// 还款金额
        /// </summary>
        [JsonProperty("repay_amt")]
        public MultiCurrencyMoneyVO RepayAmt { get; set; }
    }
}
