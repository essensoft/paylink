using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillAmtVo Data Structure.
    /// </summary>
    public class BillAmtVo : AlipayObject
    {
        /// <summary>
        /// 利息
        /// </summary>
        [JsonPropertyName("int_amt")]
        public MultiCurrencyMoneyVO IntAmt { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [JsonPropertyName("ovd_int_amt")]
        public MultiCurrencyMoneyVO OvdIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [JsonPropertyName("ovd_prin_amt")]
        public MultiCurrencyMoneyVO OvdPrinAmt { get; set; }

        /// <summary>
        /// 罚息
        /// </summary>
        [JsonPropertyName("pen_int_amt")]
        public MultiCurrencyMoneyVO PenIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [JsonPropertyName("pen_prin_amt")]
        public MultiCurrencyMoneyVO PenPrinAmt { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [JsonPropertyName("prin_amt")]
        public MultiCurrencyMoneyVO PrinAmt { get; set; }
    }
}
