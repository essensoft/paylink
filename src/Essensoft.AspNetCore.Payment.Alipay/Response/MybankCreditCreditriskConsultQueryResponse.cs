using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditCreditriskConsultQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskConsultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可贷额度，单位元
        /// </summary>
        [JsonPropertyName("available_amt")]
        public string AvailableAmt { get; set; }

        /// <summary>
        /// 咨询结果，根据具体的场景约定不同的值。  授信前准入场景，返回1表示准入，0表示不准入
        /// </summary>
        [JsonPropertyName("consult_result_code")]
        public string ConsultResultCode { get; set; }

        /// <summary>
        /// 咨询结果的描述信息。reason_code_list：不准入原因,can_manual_review:是否人工审核
        /// </summary>
        [JsonPropertyName("consult_result_msg")]
        public string ConsultResultMsg { get; set; }

        /// <summary>
        /// 授信额度，单位元
        /// </summary>
        [JsonPropertyName("creditlmt_amt")]
        public string CreditlmtAmt { get; set; }
    }
}
