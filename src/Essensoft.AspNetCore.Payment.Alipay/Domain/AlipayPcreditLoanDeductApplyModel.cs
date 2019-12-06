using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanDeductApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanDeductApplyModel : AlipayObject
    {
        /// <summary>
        /// 贷款申请单号，客户申请贷款时借呗系统生成的全局唯一业务流水号
        /// </summary>
        [JsonPropertyName("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 备注信息，机构填写的发起强扣申请的原因，要求尽量详细
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人名称，机构操作发起强扣人员姓名，用于信息追溯
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部请求幂等流水号，请求的幂等字段，申请用户贷款强扣时由机构生成的唯一请求流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
