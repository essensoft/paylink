using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRepayApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanRepayApplyModel : AlipayObject
    {
        /// <summary>
        /// 回跳地址，即商户端地址
        /// </summary>
        [JsonPropertyName("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 需要进行还款的贷款申请外部业务单号列表
        /// </summary>
        [JsonPropertyName("loan_out_biz_no_list")]
        public List<string> LoanOutBizNoList { get; set; }

        /// <summary>
        /// 还款申请业务标准外部订单号,代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 还款申请金额
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 还款类型，取值{CLEAR, OVD_AND_CURRENT}：CLEAR-结清, OVD_AND_CURRENT-逾期和当期
        /// </summary>
        [JsonPropertyName("repay_type")]
        public string RepayType { get; set; }
    }
}
