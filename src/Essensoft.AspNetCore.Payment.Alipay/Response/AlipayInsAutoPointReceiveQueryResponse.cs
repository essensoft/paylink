using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoPointReceiveQueryResponse.
    /// </summary>
    public class AlipayInsAutoPointReceiveQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次可攒积分。  例如，攒油活动，返回本次可攒油量，单位ml
        /// </summary>
        [JsonPropertyName("save_amount")]
        public long SaveAmount { get; set; }
    }
}
