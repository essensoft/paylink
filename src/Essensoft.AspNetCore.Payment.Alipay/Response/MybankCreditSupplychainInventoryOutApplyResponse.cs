using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainInventoryOutApplyResponse.
    /// </summary>
    public class MybankCreditSupplychainInventoryOutApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 待还正常利息
        /// </summary>
        [JsonPropertyName("normal_int_amt")]
        public string NormalIntAmt { get; set; }

        /// <summary>
        /// 待还逾期利息
        /// </summary>
        [JsonPropertyName("ovd_int_amt")]
        public string OvdIntAmt { get; set; }

        /// <summary>
        /// 待还逾期利息罚息
        /// </summary>
        [JsonPropertyName("ovd_int_pen_int_amt")]
        public string OvdIntPenIntAmt { get; set; }

        /// <summary>
        /// 待还逾期本金罚息
        /// </summary>
        [JsonPropertyName("ovd_prin_pen_int_amt")]
        public string OvdPrinPenIntAmt { get; set; }

        /// <summary>
        /// 待还款本金
        /// </summary>
        [JsonPropertyName("prin_amt")]
        public string PrinAmt { get; set; }

        /// <summary>
        /// 实际待还款总金额=水位差+所有利息(正常利息+逾期利息+逾期本金罚息+逾期利息罚息)，水位差 ＝ 正常本金-水位额度
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public string RepayAmt { get; set; }
    }
}
