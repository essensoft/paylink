using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayZmscoreZrankGetResponse.
    /// </summary>
    public class AlipayZmscoreZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻分分段
        /// </summary>
        [JsonPropertyName("zm_score_zrank")]
        public AlipayZmScoreZrankResult ZmScoreZrank { get; set; }
    }
}
