using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCompetitionErrorresultNotifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCompetitionErrorresultNotifyModel : AlipayObject
    {
        /// <summary>
        /// 异常类型
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 异常原因描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
