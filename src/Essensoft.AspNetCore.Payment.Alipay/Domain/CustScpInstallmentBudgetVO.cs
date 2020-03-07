using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustScpInstallmentBudgetVO Data Structure.
    /// </summary>
    public class CustScpInstallmentBudgetVO : AlipayObject
    {
        /// <summary>
        /// 是否可以还款
        /// </summary>
        [JsonPropertyName("can_repay")]
        public bool CanRepay { get; set; }

        /// <summary>
        /// 分期到期日
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 分期编号
        /// </summary>
        [JsonPropertyName("install_num")]
        public long InstallNum { get; set; }

        /// <summary>
        /// 账期开始日
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 分期状态 OVD:逾期状态,NOR:正常状态, CLR:结清状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分期金额明细
        /// </summary>
        [JsonPropertyName("term_amt_detail")]
        public CustScpBillAmtVO TermAmtDetail { get; set; }

        /// <summary>
        /// 分期总金额
        /// </summary>
        [JsonPropertyName("term_total_amt")]
        public string TermTotalAmt { get; set; }
    }
}
