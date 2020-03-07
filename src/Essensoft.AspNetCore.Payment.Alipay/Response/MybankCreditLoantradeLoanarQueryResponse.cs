using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanarQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约状态 NORMAL:正常 ,OVD:逾期, CLEAR:结清
        /// </summary>
        [JsonPropertyName("arg_status")]
        public string ArgStatus { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        [JsonPropertyName("instal_int_rate")]
        public List<InstallmentMetaInfo> InstalIntRate { get; set; }

        /// <summary>
        /// 分期还款计划
        /// </summary>
        [JsonPropertyName("installment_repay_plans")]
        public List<InstallmentRepayPlan> InstallmentRepayPlans { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 贷款期限,包含单位，有年、月、日
        /// </summary>
        [JsonPropertyName("loan_term")]
        public string LoanTerm { get; set; }

        /// <summary>
        /// 正常利息
        /// </summary>
        [JsonPropertyName("nom_int")]
        public string NomInt { get; set; }

        /// <summary>
        /// 正常本金
        /// </summary>
        [JsonPropertyName("nom_prin")]
        public string NomPrin { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [JsonPropertyName("ovd_int")]
        public string OvdInt { get; set; }

        /// <summary>
        /// 逾期利息罚息
        /// </summary>
        [JsonPropertyName("ovd_int_pen_int")]
        public string OvdIntPenInt { get; set; }

        /// <summary>
        /// 逾期本金
        /// </summary>
        [JsonPropertyName("ovd_prin")]
        public string OvdPrin { get; set; }

        /// <summary>
        /// 逾期本金罚息
        /// </summary>
        [JsonPropertyName("ovd_prin_pen_int")]
        public string OvdPrinPenInt { get; set; }

        /// <summary>
        /// 还款方式。若为分段还款，则存储的为分段还款方式的分段值。否则，该list仅含一个元素，为当前的还款方式
        /// </summary>
        [JsonPropertyName("repay_modes")]
        public List<InstallmentMetaInfo> RepayModes { get; set; }
    }
}
