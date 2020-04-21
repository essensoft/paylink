using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeShoptransferConsultResponse.
    /// </summary>
    public class MybankCreditLoantradeShoptransferConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 咨询结果,allow(允许转让)/refuse(拒绝)
        /// </summary>
        [JsonPropertyName("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// 拒绝码
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝文案
        /// </summary>
        [JsonPropertyName("refuse_desc")]
        public string RefuseDesc { get; set; }
    }
}
