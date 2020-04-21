using System.Text.Json.Serialization;

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
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 正常利息金额
        /// </summary>
        [JsonPropertyName("intr")]
        public string Intr { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [JsonPropertyName("ovd_fine")]
        public string OvdFine { get; set; }

        /// <summary>
        /// 逾期利息金额
        /// </summary>
        [JsonPropertyName("ovd_int")]
        public string OvdInt { get; set; }

        /// <summary>
        /// 逾期利息罚息
        /// </summary>
        [JsonPropertyName("ovd_int_pny")]
        public string OvdIntPny { get; set; }

        /// <summary>
        /// 逾期本金金额
        /// </summary>
        [JsonPropertyName("ovd_prin")]
        public string OvdPrin { get; set; }

        /// <summary>
        /// 逾期本金罚息
        /// </summary>
        [JsonPropertyName("ovd_prin_pny")]
        public string OvdPrinPny { get; set; }

        /// <summary>
        /// 正常本金金额
        /// </summary>
        [JsonPropertyName("prin")]
        public string Prin { get; set; }
    }
}
