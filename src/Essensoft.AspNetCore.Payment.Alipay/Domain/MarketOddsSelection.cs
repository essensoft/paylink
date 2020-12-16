using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketOddsSelection Data Structure.
    /// </summary>
    public class MarketOddsSelection : AlipayObject
    {
        /// <summary>
        /// 不同玩法含义不一样  胜平负   1: 主胜   0: 平   -1: 客胜 首个进球   1: 主进球   0: 都未进球   -1: 客进球
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 赔率
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 结果 1: 赢 0.5: 半赢（预留） 0: 退款 -0.5: 半输（预留） -1: 输
        /// </summary>
        [JsonPropertyName("result")]
        public long Result { get; set; }
    }
}
