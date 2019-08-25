using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanLoanApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanLoanApplyModel : AlipayObject
    {
        /// <summary>
        /// 贷款申请金额
        /// </summary>
        [JsonProperty("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 回跳地址，即商户端地址
        /// </summary>
        [JsonProperty("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 贷款用途，取值{DAILY_SHOPPING, DECORATION, TOUR, EDUCATION, MEDICAL}：DAILY_SHOPPING-个人日常消费; DECORATION-装修; TOUR-旅游; EDUCATION-教育; MEDICAL-医疗;
        /// </summary>
        [JsonProperty("loan_purpose")]
        public string LoanPurpose { get; set; }

        /// <summary>
        /// 贷款期限，包含贷款期数和期数单位
        /// </summary>
        [JsonProperty("loan_term")]
        public LoanTerm LoanTerm { get; set; }

        /// <summary>
        /// 贷款申请业务标准外部订单号,代表商户端自己订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 还款方式，取值{1, 3, 6}：1-等额本息; 3-按期付息到期还本;  6-到期一次性还本付息;
        /// </summary>
        [JsonProperty("repay_mode")]
        public string RepayMode { get; set; }
    }
}
