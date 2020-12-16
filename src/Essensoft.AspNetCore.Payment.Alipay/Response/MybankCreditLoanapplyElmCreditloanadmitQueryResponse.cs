using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyElmCreditloanadmitQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyElmCreditloanadmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可贷额度标签
        /// </summary>
        [JsonPropertyName("admit_label")]
        public string AdmitLabel { get; set; }
    }
}
