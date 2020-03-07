using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCreditPayConsultResponse.
    /// </summary>
    public class AlipayTradeCreditPayConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 准入咨询结果AVAILABLE：可用；UNAVAILABLE：不可用。
        /// </summary>
        [JsonPropertyName("consult_result")]
        public string ConsultResult { get; set; }
    }
}
