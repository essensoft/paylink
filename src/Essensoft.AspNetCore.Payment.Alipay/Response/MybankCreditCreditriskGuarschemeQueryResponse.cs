using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskGuarschemeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用担保额度
        /// </summary>
        [JsonPropertyName("available_amt")]
        public string AvailableAmt { get; set; }
    }
}
