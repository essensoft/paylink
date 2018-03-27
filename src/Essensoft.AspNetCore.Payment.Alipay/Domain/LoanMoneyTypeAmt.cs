using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanMoneyTypeAmt Data Structure.
    /// </summary>
    public class LoanMoneyTypeAmt : AlipayObject
    {
        /// <summary>
        /// 费用
        /// </summary>
        [JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 正常利息金额
        /// </summary>
        [JsonProperty("intr")]
        public string Intr { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [JsonProperty("ovd_fine")]
        public string OvdFine { get; set; }

        /// <summary>
        /// 逾期利息金额
        /// </summary>
        [JsonProperty("ovd_int")]
        public string OvdInt { get; set; }

        /// <summary>
        /// 逾期利息罚息
        /// </summary>
        [JsonProperty("ovd_int_pny")]
        public string OvdIntPny { get; set; }

        /// <summary>
        /// 逾期本金金额
        /// </summary>
        [JsonProperty("ovd_prin")]
        public string OvdPrin { get; set; }

        /// <summary>
        /// 逾期本金罚息
        /// </summary>
        [JsonProperty("ovd_prin_pny")]
        public string OvdPrinPny { get; set; }

        /// <summary>
        /// 正常本金金额
        /// </summary>
        [JsonProperty("prin")]
        public string Prin { get; set; }
    }
}
