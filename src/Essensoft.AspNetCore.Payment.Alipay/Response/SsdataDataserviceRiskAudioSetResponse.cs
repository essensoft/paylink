using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAudioSetResponse.
    /// </summary>
    public class SsdataDataserviceRiskAudioSetResponse : AlipayResponse
    {
        /// <summary>
        /// 查询出的关键词数量
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 关键词结果
        /// </summary>
        [JsonPropertyName("keyword_list")]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// 结果是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
