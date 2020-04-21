using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundStudentloanRepayQueryResponse.
    /// </summary>
    public class AlipayFundStudentloanRepayQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务类型 A生源地 B高校
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 学生所在分行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 学生所在区县或高校
        /// </summary>
        [JsonPropertyName("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 还款日期，格式yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 还款明细列表
        /// </summary>
        [JsonPropertyName("repay_list")]
        public List<RepayDetail> RepayList { get; set; }

        /// <summary>
        /// 学生当前应还金额汇总
        /// </summary>
        [JsonPropertyName("should_amount")]
        public string ShouldAmount { get; set; }

        /// <summary>
        /// 李某
        /// </summary>
        [JsonPropertyName("student_name")]
        public string StudentName { get; set; }
    }
}
