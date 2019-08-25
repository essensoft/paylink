using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustScpInstallmentBudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustScpInstallmentBudgetVO : AlipayObject
    {
        /// <summary>
        /// 是否可以还款
        /// </summary>
        [JsonProperty("can_repay")]
        public bool CanRepay { get; set; }

        /// <summary>
        /// 分期到期日
        /// </summary>
        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 分期编号
        /// </summary>
        [JsonProperty("install_num")]
        public long InstallNum { get; set; }

        /// <summary>
        /// 账期开始日
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 分期状态 OVD:逾期状态,NOR:正常状态, CLR:结清状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分期金额明细
        /// </summary>
        [JsonProperty("term_amt_detail")]
        public CustScpBillAmtVO TermAmtDetail { get; set; }

        /// <summary>
        /// 分期总金额
        /// </summary>
        [JsonProperty("term_total_amt")]
        public string TermTotalAmt { get; set; }
    }
}
