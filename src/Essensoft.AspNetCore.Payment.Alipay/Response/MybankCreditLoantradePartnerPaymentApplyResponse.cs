using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentApplyResponse.
    /// </summary>
    public class MybankCreditLoantradePartnerPaymentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 网商内部申请单编号，外部机构根据此编号查询申请状态。
        /// </summary>
        [JsonPropertyName("in_apply_no")]
        public string InApplyNo { get; set; }
    }
}
