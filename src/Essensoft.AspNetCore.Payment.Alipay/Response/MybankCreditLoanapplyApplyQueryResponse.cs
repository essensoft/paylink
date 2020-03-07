using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyApplyQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyApplyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请贷款额度
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [JsonPropertyName("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 申请单编号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 审批结论，审批通过或者拒绝
        /// </summary>
        [JsonPropertyName("approve_conclu")]
        public string ApproveConclu { get; set; }

        /// <summary>
        /// 审批通过后返回的授信信息
        /// </summary>
        [JsonPropertyName("approve_credit_result")]
        public ApproveCreditResult ApproveCreditResult { get; set; }

        /// <summary>
        /// 审批完成时间
        /// </summary>
        [JsonPropertyName("approve_finish_date")]
        public string ApproveFinishDate { get; set; }

        /// <summary>
        /// 客户机构ISV ipRoleId
        /// </summary>
        [JsonPropertyName("cust_inst_appid")]
        public string CustInstAppid { get; set; }

        /// <summary>
        /// 客户机构ipRoleId
        /// </summary>
        [JsonPropertyName("cust_inst_code")]
        public string CustInstCode { get; set; }

        /// <summary>
        /// 返回的扩展字段，预留
        /// </summary>
        [JsonPropertyName("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 数据项的采集结果
        /// </summary>
        [JsonPropertyName("investig_category_result")]
        public List<InvestigCategoryResult> InvestigCategoryResult { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 申贷类型
        /// </summary>
        [JsonPropertyName("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 运营产品CODE
        /// </summary>
        [JsonPropertyName("op_prod_code")]
        public string OpProdCode { get; set; }

        /// <summary>
        /// 运营产品CODE版本
        /// </summary>
        [JsonPropertyName("op_prod_code_version")]
        public string OpProdCodeVersion { get; set; }

        /// <summary>
        /// 审批拒绝原因CODE，多个以逗号分隔，默认为null
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 调查结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
