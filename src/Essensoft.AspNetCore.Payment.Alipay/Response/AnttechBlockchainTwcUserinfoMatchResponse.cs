using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainTwcUserinfoMatchResponse.
    /// </summary>
    public class AnttechBlockchainTwcUserinfoMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID对应的sha256的hash值
        /// </summary>
        [JsonPropertyName("cousumer_id_hash")]
        public string CousumerIdHash { get; set; }

        /// <summary>
        /// 不匹配的原因描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 匹配是否成功
        /// </summary>
        [JsonPropertyName("match_success")]
        public bool MatchSuccess { get; set; }
    }
}
