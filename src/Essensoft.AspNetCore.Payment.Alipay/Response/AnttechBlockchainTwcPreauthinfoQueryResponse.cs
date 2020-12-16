using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainTwcPreauthinfoQueryResponse.
    /// </summary>
    public class AnttechBlockchainTwcPreauthinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息若不一致，错误信息状态描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 是否核验通过
        /// </summary>
        [JsonPropertyName("match")]
        public bool Match { get; set; }

        /// <summary>
        /// 订单信息是否匹配
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
