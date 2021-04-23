using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateInfoScoreQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateInfoScoreQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 成绩评价
        /// </summary>
        [JsonPropertyName("score_evaluate")]
        public string ScoreEvaluate { get; set; }

        /// <summary>
        /// 成绩类型：分数：grade，等第：order，奖项等级：level，奖项级别：rank，奖牌：medal，自定义：user_defined
        /// </summary>
        [JsonPropertyName("score_type")]
        public string ScoreType { get; set; }

        /// <summary>
        /// 分数：浮点型，最多两位小数，等第：（S、A、B、C、D），奖项等级：一等奖、二等奖、三等奖、……），奖项级别：金奖、银奖、铜奖），奖牌：金牌、银牌、铜牌），自定义：奖项名称不能超过10个汉字
        /// </summary>
        [JsonPropertyName("score_value")]
        public string ScoreValue { get; set; }
    }
}
