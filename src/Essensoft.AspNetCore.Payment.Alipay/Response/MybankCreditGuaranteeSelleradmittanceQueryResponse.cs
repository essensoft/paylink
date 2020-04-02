using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditGuaranteeSelleradmittanceQueryResponse.
    /// </summary>
    public class MybankCreditGuaranteeSelleradmittanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询decision是否准入。为空表示不准入
        /// </summary>
        [JsonPropertyName("is_admitted")]
        public bool IsAdmitted { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [JsonPropertyName("is_signed")]
        public bool IsSigned { get; set; }

        /// <summary>
        /// 是否解约AE提前收款，为空表示未解约
        /// </summary>
        [JsonPropertyName("is_unsigned")]
        public bool IsUnsigned { get; set; }

        /// <summary>
        /// 解约时间，为空表示无解约时间
        /// </summary>
        [JsonPropertyName("unsign_date")]
        public string UnsignDate { get; set; }
    }
}
