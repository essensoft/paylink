using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainTwcTradeinfoQueryResponse.
    /// </summary>
    public class AnttechBlockchainTwcTradeinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单核验的结果说明
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否与订单的信息一致
        /// </summary>
        [JsonPropertyName("match")]
        public bool Match { get; set; }

        /// <summary>
        /// 订单核验的结果状态码
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
