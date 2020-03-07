using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditGuaranteeSelleradmittanceQueryResponse.
    /// </summary>
    public class MybankCreditGuaranteeSelleradmittanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询decision是否准入
        /// </summary>
        [JsonPropertyName("is_admitted")]
        public bool IsAdmitted { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [JsonPropertyName("is_signed")]
        public bool IsSigned { get; set; }
    }
}
