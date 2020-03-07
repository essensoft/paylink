using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeLevelQueryResponse.
    /// </summary>
    public class ZhimaCreditPeLevelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的芝麻分分级编码。分值范围[A,B,C,D,E]。如果用户数据不足，无法评分时，返回字符串"N/A"。
        /// </summary>
        [JsonPropertyName("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 用户的芝麻分分级描述。分值范围[信用极好，信用优秀，信用良好，信用中等，信用较差]。如果用户数据不足，无法评分时，返回字符串"N/A"。
        /// </summary>
        [JsonPropertyName("level_name")]
        public string LevelName { get; set; }
    }
}
