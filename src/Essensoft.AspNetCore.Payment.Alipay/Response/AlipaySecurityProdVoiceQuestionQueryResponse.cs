using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdVoiceQuestionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdVoiceQuestionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 问题推荐结果
        /// </summary>
        [JsonPropertyName("question_result")]
        public string QuestionResult { get; set; }
    }
}
