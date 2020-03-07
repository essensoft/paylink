using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossCsCssocialYqmessageQueryResponse.
    /// </summary>
    public class AlipayBossCsCssocialYqmessageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的舆情数据结果字符串。舆情数据及信息存放在JSON字符串中，如舆情的标题（title）、内容（content）等
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
