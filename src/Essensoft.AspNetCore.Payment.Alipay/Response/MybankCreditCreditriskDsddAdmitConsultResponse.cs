using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditCreditriskDsddAdmitConsultResponse.
    /// </summary>
    public class MybankCreditCreditriskDsddAdmitConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 在status为ADMIT时，此字段必填。 表示准入额度对应的等级，等级越高，额度越大。 目前值为1-3。
        /// </summary>
        [JsonPropertyName("amt_grade")]
        public string AmtGrade { get; set; }

        /// <summary>
        /// 表示准入查询结果的状态信息。 ADMIT：准入 NO_ADMIT：不准入
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
