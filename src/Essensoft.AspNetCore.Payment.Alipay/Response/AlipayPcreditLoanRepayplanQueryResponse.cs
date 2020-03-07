using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRepayplanQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanRepayplanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款合约编号，每笔用户贷款申请时，放款签约时生成的唯一合约编号，作为用户贷款账单的唯一标识
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 当前期次，与term_unit期次单位配合使用，表示当前所在期次；如果合约最后一期计划都已经逾期,就不存在当期计划
        /// </summary>
        [JsonPropertyName("current_term")]
        public long CurrentTerm { get; set; }

        /// <summary>
        /// 贷款到期日，格式：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 贷款申请单号，借呗客户申请贷款时系统生成的全局唯一业务流水号
        /// </summary>
        [JsonPropertyName("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 贷款生效时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 逾期发生时间，格式：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("ovd_date")]
        public string OvdDate { get; set; }

        /// <summary>
        /// 剩余还款金额
        /// </summary>
        [JsonPropertyName("remain_repay_amt")]
        public LoanMoneyTypeAmt RemainRepayAmt { get; set; }

        /// <summary>
        /// 还款方式，由借呗约定，目前支持的还款方式有：  1-等额本息  2-等额本金  3-先息后本  6-到期一次还本付息
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 还款计划分期信息
        /// </summary>
        [JsonPropertyName("repay_plan_term_list")]
        public List<LoanRepayPlanTerm> RepayPlanTermList { get; set; }

        /// <summary>
        /// 该还款计划所在的会计日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 合约状态，状态枚举如下：  NORMAL-正常  OVD-逾期  CLEAR-结清
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 期限单位，和term配合使用，目前支持的期限单位有：  D-天  M-月  Y-年
        /// </summary>
        [JsonPropertyName("term_unit")]
        public string TermUnit { get; set; }

        /// <summary>
        /// 贷款期限，配合term_unit期限单位，或表示贷款天数或期数
        /// </summary>
        [JsonPropertyName("terms")]
        public long Terms { get; set; }
    }
}
